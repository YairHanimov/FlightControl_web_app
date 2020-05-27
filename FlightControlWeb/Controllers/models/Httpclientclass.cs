using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class Httpclientclass
    {
        public async Task<dynamic> makeRequest(string url)
        {
            using var client = new HttpClient();
            var result = await client.GetStringAsync(url);
            return result;
        }
    }
}
