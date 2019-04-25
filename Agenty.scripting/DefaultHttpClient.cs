using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgentyScripting
{
    internal class DefaultHttpClient : HttpClient
    {
        private DefaultHttpClient()
        {

        }
        private static readonly Uri BaseUrl = new Uri("https://api.agenty.com/v1/");

        public static HttpClient CreateDefault()
        {
            var httpClient = new DefaultHttpClient();
            return ApplyDefaults(httpClient);
        }
        public static HttpClient ApplyDefaults(HttpClient httpClient)
        {
            if (httpClient == null) throw new ArgumentNullException(nameof(httpClient));
            httpClient.DefaultRequestHeaders.Add("X-Agenty-ApiKey", Agenty.ApiKey);
            if (httpClient.BaseAddress == null)
            {
                httpClient.BaseAddress = BaseUrl;
            }
            if (httpClient.DefaultRequestHeaders.UserAgent.Count == 0)
            {
                httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Agenty.scripting", "1.0"));
            }
            if (httpClient.DefaultRequestHeaders.Accept.Count == 0)
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
            return httpClient;
        }
    }
}
