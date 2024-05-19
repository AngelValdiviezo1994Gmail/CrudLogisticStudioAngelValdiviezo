using AngelValdiviezoWebApi.Application.Features.Cliente.Dto;
using AngelValdiviezoWebApi.Domain.Constant;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using WebApp.Models.Registros;
using WebAppCrudAngelValdiviezo.ViewModel.Auth;

namespace WebApp.Services
{
    public class Cliente_Service
    {
        private readonly HttpClient _httpClient;
        private readonly Conexion _Conexion;

        public Cliente_Service(HttpClient httpClient)
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

        public async Task<HttpResponseMessage> GetListaGeneros(string token)
        {
            try
            {
                string Ruta = string.Concat(_Conexion.Puerto, _Conexion.ApiGenero, "GetGenero");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(Ruta);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

        public async Task<HttpResponseMessage> GetListaTipoCliente(string token)
        {
            try
            {
                string Ruta = string.Concat(_Conexion.Puerto, _Conexion.ApiTipoCliente, "GetTipoCliente");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(Ruta);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

        public async Task<HttpResponseMessage> GetListaEstadoCivil(string token)
        {
            try
            {
                string Ruta = string.Concat(_Conexion.Puerto, _Conexion.ApiEstCivil, "GetEstadoCivil");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(Ruta);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

        /*
         var cliente = new Cliente
        {
            IdCliente = 0,
            NombreCliente = "mel",
            ApellidoCliente = "canc",
            NumCtaCliente = "123456",
            SaldoCliente = 20,
            FechaNacimientoCliente = DateTime.Parse("2024-05-19T21:59:20.231Z"),
            DireccionCliente = "duran",
            TelefonoCliente = "0988556677",
            EmailCliente = "m.vilema@gmail.com",
            IdTipoCliente = 2,
            IdEstadoCivilCliente = 1,
            NumIdentificacionCliente = "0940010119",
            ProfesionCliente = "DR",
            IdGeneroCliente = 2,
            NacionalidadCliente = "EC",
            UsuarioCreacion = "ang",
            FechaCreacion = DateTime.Parse("2024-05-19T21:59:20.231Z"),
            UsuarioModificacion = "ang",
            FechaModificacion = DateTime.Parse("2024-05-19T21:59:20.231Z")
        };

        var json = JsonConvert.SerializeObject(cliente);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var url = "https://localhost:7203/api/v1/Cliente/CreateCliente";
        using var client = new HttpClient();

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZGVudGlmaWNhY2lvbiI6IjA5NDAwMTAxMTkiLCJuYmYiOjE3MTYxNTYxNDIsImV4cCI6MTcyOTI5NjE0MiwiaWF0IjoxNzE2MTU2MTQyfQ.JuXtEm5ZHBWrAelW2ieLOdQc7J9xiE_c64bNoiU5fkE");

        var response = await client.PostAsync(url, data);

         */

        public async Task<HttpResponseMessage> CreateCliente(ClienteType OCltType, string token)
        {
            ClienteRegistro ObjClienteRegistro = new ClienteRegistro 
            { 
                apellidoCliente = OCltType.ClientApellido,
                direccionCliente = OCltType.ClientDireccion,
                emailCliente = OCltType.ClientEmail,
                fechaCreacion = OCltType.FechaCreacion,
                fechaModificacion = OCltType.FechaModificacion,
                fechaNacimientoCliente = OCltType.ClientFechaNacimiento,
                idCliente = OCltType.ClientId,
                idEstadoCivilCliente = OCltType.ClientEstadoCivilId,
                idGeneroCliente = OCltType.ClientGeneroId,
                idTipoCliente = OCltType.ClientTipoId,
                nacionalidadCliente = OCltType.ClientNacionalidad,
                nombreCliente = OCltType.ClientNombre,
                numCtaCliente = OCltType.ClientNumCta,
                numIdentificacionCliente = OCltType.ClientNumIdentificacion,
                profesionCliente = OCltType.ClientProfesion,
                saldoCliente = OCltType.ClientSaldo,
                telefonoCliente = OCltType.ClientTelefono,
                usuarioCreacion = OCltType.UsuarioCreacion,
                usuarioModificacion = OCltType.UsuarioModificacion
            };
            
            var json = JsonConvert.SerializeObject(ObjClienteRegistro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                string Ruta = string.Concat(_Conexion.Puerto, _Conexion.ApiCliente, "CreateCliente");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.PostAsync(Ruta, content);
                
                /*
                using var client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                
                var response = await client.PostAsync(Ruta, content);
                */

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage();
            }
        }

    }
}
