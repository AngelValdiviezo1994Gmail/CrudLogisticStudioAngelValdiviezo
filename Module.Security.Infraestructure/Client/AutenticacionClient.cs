using Common.Domain.Wrappers;
using Module.Security.Infraestructure.DTO;
using Module.Security.Infraestructure.Interfaces.Client;

namespace Module.Security.Infraestructure.Client
{
    public class AutenticacionClient : IAutenticacionClient
    {
        private readonly HttpClient _httpClient;

        public AutenticacionClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<UserDTO>> Loggin(Request<LoginRequestDTO> request)
        {
            var response = await _httpClient.GetAsync("https://api.example.com/data");
            response.EnsureSuccessStatusCode();

            //await response.Content.ReadAsStringAsync();
            return new Response<UserDTO>();
        }
    }
}
