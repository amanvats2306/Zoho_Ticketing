using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using Zoho_Ticketing.Models;

namespace Zoho_Ticketing.Services
{
    public class ZohoDeskService
    {
        private readonly HttpClient _httpClient;
        public ZohoDeskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CreateTicketAsync(string accessToken, ZohoTicketRequest request)
        {

            _httpClient.BaseAddress = new Uri("https://desk.zoho.com/api/v1/tickets");
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Zoho-oauthtoken", accessToken);

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("tickets", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
