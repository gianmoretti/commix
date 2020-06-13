using Commix.Models;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Commix.Services
{
    class WebServiceClient
    {

        HttpClient httpClient;
       
        public WebServiceClient()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> Get(string userId)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string apiUri = $"{appSettings.Get("wsUrl")}{userId}";
            HttpResponseMessage response = await httpClient.GetAsync(apiUri);

            string json = await response.Content.ReadAsStringAsync();
            return json;
        }

    }
}
