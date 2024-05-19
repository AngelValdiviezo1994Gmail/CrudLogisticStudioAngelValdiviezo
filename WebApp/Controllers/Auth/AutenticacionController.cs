using Microsoft.AspNetCore.Mvc;
using WebAppCrudAngelValdiviezo.Extensions;
using WebAppCrudAngelValdiviezo.ViewModel.Auth;
using Newtonsoft.Json;
using System.Text;
using AngelValdiviezoWebApi.Application.Features.Token.Dto;
using WebApp.Controllers;
using AngelValdiviezoWebApi.Domain.Constant;
using WebApp.Services;
using Microsoft.AspNetCore.Http;
using AngelValdiviezoWebApi.Application.Common.Wrappers;

namespace WebAppCrudAngelValdiviezo.Controllers.Auth
{
    public class AutenticacionController : BaseController
    {
        private readonly HttpClient _httpClient;
        private readonly Conexion _Conexion;

        public AutenticacionController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _Conexion = new Conexion();
        }
        
        public async Task<ActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            AuthService OAuthService = new AuthService(_httpClient);

            try
            {
                var response = await OAuthService.Login(login);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var resultModel = JsonConvert.DeserializeObject<ResponseType<string>>(responseData);
                    
                    HttpContext.Session.SetString("JwtSesion", resultModel.Data);

                    return RedirectToAction(nameof(Index), RemoveController(nameof(HomeController)));
                }
                else
                {
                    // Manejar el error
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }
            
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }


    }
}
