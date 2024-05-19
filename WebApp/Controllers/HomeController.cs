using AngelValdiviezoWebApi.Application.Common.Wrappers;
using AngelValdiviezoWebApi.Application.Features.Cliente.Dto;
using AngelValdiviezoWebApi.Application.Features.Token.Dto;
using AngelValdiviezoWebApi.Domain.Entities;
using AngelValdiviezoWebApi.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
//using Module.Security.Infraestructure.Interfaces.Client;
using System.Diagnostics;
using System.Net.Http;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModel;
using WebAPP.Filters;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string? op)
        {
            ClienteService OClientService = new ClienteService(_httpClient);

            OpcionesTablaViewModel opciones = TableViewHelper.GetParametros(op);
            List<Filtro> filtros = new();
            RequestPaged getGeneroRequest = new(filtros)
            {
                Cantidad = opciones.cantidadMostrar.HasValue ? opciones.cantidadMostrar.Value : 10,
                Pagina = opciones.pagina.HasValue ? opciones.pagina.Value : 1,                
            };

            if (!string.IsNullOrWhiteSpace(opciones.propiedadOrden) && opciones.tipoOrden != null)
            {
                getGeneroRequest.Orden = new OrdenFiltro
                {
                    PropiedadBusqueda = opciones.propiedadOrden,
                    Orden = (OrdenFiltroEnum)opciones.tipoOrden
                };
            }
            /*
            ResponsePaged<List<Genero>> listaGenero = await _iGeneroClient.GetGeneros(getGeneroRequest);
            ResponsePaged<List<GeneroListViewModel>> responseList = _executionOrchestrator.Mapper.Map<ResponsePaged<List<GeneroListViewModel>>>(listaGenero);
            responseList.Data = responseList.Data.Where(x => x.GenActivo == true).OrderBy(x => x.GenId).ToList();
            */
            List<ClienteType> LstClientes = new List<ClienteType>();

            string Token = HttpContext.Session.GetString("JwtSesion") ?? string.Empty;

            var response = await OClientService.GetClientes(Token);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                //LstClientes = JsonConvert.DeserializeObject<List<ClienteType>>(responseData);
                LstClientes = JsonConvert.DeserializeObject<ResponseType<List<ClienteType>>>(responseData).Data;

            }

            return View(LstClientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [AuthorizationFilter]
        public IActionResult EnConstruccion()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}