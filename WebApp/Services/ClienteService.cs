using AngelValdiviezoWebApi.Domain.Constant;
using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;
using System.Text;
using WebAppCrudAngelValdiviezo.ViewModel.Auth;

namespace WebApp.Services
{
    public class ClienteService
    {
        private readonly HttpClient _httpClient;
        private readonly Conexion _Conexion;

        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _Conexion = new Conexion();
        }

        public async Task<HttpResponseMessage> GetClientes(string token)
        {
            try
            {
                string Ruta = string.Concat(_Conexion.Puerto, _Conexion.ApiCliente, "GetClientes");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(Ruta);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

    }
}
