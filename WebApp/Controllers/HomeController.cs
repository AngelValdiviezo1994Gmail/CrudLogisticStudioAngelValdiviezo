﻿using AngelValdiviezoWebApi.Application.Common.Wrappers;
using AngelValdiviezoWebApi.Application.Features.Catalogo.EstadoCivil.Dto;
using AngelValdiviezoWebApi.Application.Features.Catalogo.TipoCliente.Dto;
using AngelValdiviezoWebApi.Application.Features.Cliente.Dto;
using AngelValdiviezoWebApi.Application.Features.Genero.Dto;
using AngelValdiviezoWebApi.Application.Features.Genero.Interfaces;
using AngelValdiviezoWebApi.Domain.Entities;
using AngelValdiviezoWebApi.Domain.Enums;
using AngelValdiviezoWebApi.Persistence.Repository.Cliente;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Diagnostics;
using WebApp.Controllers.Clientes;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModel;
using WebApp.ViewModel;
using WebAPP.Filters;
using static WebAppCrudAngelValdiviezo.Extensions.BaseController;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
            => (
            _logger,
            _httpClient
            )
            =
            (
            logger,
            httpClient);


        public async Task<IActionResult> Index(string? op)
        {
            ResponsePaged<List<ClienteListViewModel>> LstFinal = new ResponsePaged<List<ClienteListViewModel>>();
            Cliente_Service OClientService = new Cliente_Service(_httpClient);

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

            List<ClienteType> LstClientes = new List<ClienteType>();

            string Token = HttpContext.Session.GetString("JwtSesion") ?? string.Empty;

            var response = await OClientService.GetClientes(Token);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                
                LstClientes = JsonConvert.DeserializeObject<ResponseType<List<ClienteType>>>(responseData).Data;

                var OConvertido = new ResponsePaged<List<ClienteType>>
                {
                    Succeeded = true,
                    Error = string.Empty,
                    ErrorCode = 0,
                    Data = LstClientes,
                    Cantidad = LstClientes.Count,
                    Pagina = 1,
                    TotalElementos = LstClientes.Count,
                    TotalPaginas = LstClientes.Count / 5,                    
                };
                List<ClienteListViewModel> LstTmp = new List<ClienteListViewModel>();

                foreach (ClienteType item in LstClientes)
                {
                    LstTmp.Add(
                        new ClienteListViewModel 
                        {
                            ClientApellido = item.ClientApellido,
                            ClientDireccion = item.ClientDireccion,
                            ClientEmail = item.ClientEmail,
                            ClientEstadoCivilId = item.ClientEstadoCivilId,
                            ClientFechaNacimiento = item.ClientFechaNacimiento,
                            ClientGeneroId = item.ClientGeneroId,
                            ClientId = item.ClientId,
                            ClientNacionalidad = item.ClientNacionalidad,
                            ClientNombre = item.ClientNombre,
                            ClientNumCta = item.ClientNumCta,
                            ClientNumIdentificacion = item.ClientNumIdentificacion,
                            ClientProfesion = item.ClientProfesion,
                            ClientSaldo = item.ClientSaldo,
                            ClientTelefono = item.ClientTelefono,
                            ClientTipoId = item.ClientTipoId,
                            FechaCreacion = item.FechaCreacion,
                            FechaModificacion = item.FechaModificacion,
                            UsuarioCreacion = item.UsuarioCreacion,
                            UsuarioModificacion = item.UsuarioModificacion
                        }
                        );
                }
                
                LstFinal.Data = LstTmp;
            }

            return View(LstFinal);
        }

        public IActionResult Create()        
        {
            return RedirectToAction(nameof(Create), RemoveController(nameof(ClientesController))); //Enviamos a HOME
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

        #region Funciones
        public string RemoveController(string value)
        {
            string result = value.Replace("Controller", "");

            return result;
        }
        #endregion
    }
}