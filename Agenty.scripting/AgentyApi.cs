using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AgentyScripting
{
    class AgentyApi
    {
        internal async Task<AgentyResponse> GetAgentResult(string agentId, int collection, int modified)
        {            
            var httpClient = DefaultHttpClient.CreateDefault();
            var response = await httpClient.GetAsync($"results/{agentId}?collection={collection}&modified={modified}");
            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<AgentyResponse>();
                return result;
            }
            throw new AgentyException($"Request error. StatusCode : {response.StatusCode}, Message : {response.Content}");
        }

        internal async Task<AgentyResponse> GetListRows(int listId)
        {
            var httpClient = DefaultHttpClient.CreateDefault();
            var response = await httpClient.GetAsync($"lists/{listId}/rows");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<AgentyResponse>();
                return result;
            }
            throw new AgentyException($"Request error. StatusCode : {response.StatusCode}, Message : {response.Content}");
        }

        internal async Task<AgentyResponse> GetAgentInput(string agentId)
        {
            var httpClient = DefaultHttpClient.CreateDefault();
            var response = await httpClient.GetAsync($"inputs/{agentId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<AgentyResponse>();
                return result;
            }
            throw new AgentyException($"Request error. StatusCode : {response.StatusCode}, Message : {response.Content}");
        }
    }
}
