using Microsoft.AspNetCore.Mvc;
using WebAppCrudAngelValdiviezo.Extensions;
using WebAppCrudAngelValdiviezo.ViewModel.Auth;
using Newtonsoft.Json;
using System.Text;
using AngelValdiviezoWebApi.Application.Features.Token.Dto;
using WebApp.Controllers;

namespace WebAppCrudAngelValdiviezo.Controllers.Auth
{
    public class AutenticacionController : BaseController
    {
        private readonly HttpClient _httpClient;

        public AutenticacionController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<ActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("https://localhost:7203/api/v1/Token/CreateToken", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var resultModel = JsonConvert.DeserializeObject<TokenType>(responseData);

                    return RedirectToAction(nameof(Index), RemoveController(nameof(HomeController))); //Enviamos a HOME
                }
                else
                {
                    // Manejar el error
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                return StatusCode(500, ex.Message);
            }
            
        }


    }
}
