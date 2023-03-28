using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class KandilliAPI : IEarthquakeAPI
    {
        private readonly HttpClient client;
        private readonly string apiUrl;

        public KandilliAPI(HttpClient httpClient, string apiUrl)
        {
            client = httpClient;
            this.apiUrl = apiUrl;
        }

        public async Task<string> GetAsync()
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
