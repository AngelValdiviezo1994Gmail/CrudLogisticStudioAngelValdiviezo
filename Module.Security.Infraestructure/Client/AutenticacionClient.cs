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
            /*
            var response = await _httpClient.GetAsync("https://api.example.com/data");
            response.EnsureSuccessStatusCode();
            */
            using (HttpClient client = new HttpClient())
            {
                /*
                 
                  var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://localhost:5001/api/example", content);
       
                 */
                client.BaseAddress = new Uri("https://localhost:7203/");
                HttpResponseMessage response = await client.GetAsync("api/v1/Token/CreateToken");
                response.EnsureSuccessStatusCode();

                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseData);
            }

            return new Response<UserDTO>();
        }
    }
}
