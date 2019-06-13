using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentyScripting
{
    public static class Agenty
    {
        public static string ApiKey { get; set; }
        public static string ApiEndPoint = "https://api.agenty.com/v1";

        public static class Cloud
        {
            //public static DataTable GetAgentInput(string agentId)
            //{
            //    if(string.IsNullOrEmpty(ApiKey))
            //    {
            //        throw new AgentyException($"ApiKey is not set. Use the Agenty.ApiKey = [your api key] to set your api key first");
            //    }
            //    // Get the agent input from API
            //    var api = new AgentyApi();
            //    var response = api.GetAgentInput(agentId).Result;
            //    if (response != null && response.result != null)
            //    {
            //       // Convert to DataTable
            //        var json = JsonConvert.SerializeObject(response.result);
            //        DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            //        return table;
            //    }
            //    return null;
            //}

            public static DataTable GetAgentResult(string agentId, int? Version = null, int Collection = 1, int Modified = 0)
            {
                if (string.IsNullOrEmpty(ApiKey))
                {
                    throw new AgentyException($"ApiKey is not set. Use the Agenty.ApiKey = [your api key] to set your api key first");
                }
                // Get the agent result from API
                var api = new AgentyApi();
                var response = api.GetAgentResult(agentId, Collection, Modified).Result;
                if(response != null && response.result != null)
                {
                    // Convert to DataTable
                    var json = JsonConvert.SerializeObject(response.result);
                    DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                    return table;
                }
                return null;
            }

            public static DataTable GetList(int ListId)
            {
                if (string.IsNullOrEmpty(ApiKey))
                {
                    throw new AgentyException($"ApiKey is not set. Use the Agenty.ApiKey = [your api key] to set your api key first");
                }
                // Get the agent result from API
                var api = new AgentyApi();
                var response = api.GetListRows(ListId).Result;
                if (response != null && response.result != null)
                {
                    // Convert to DataTable
                    var json = JsonConvert.SerializeObject(response.result);
                    DataTable table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                    return table;
                }
                return null;
            }
        }

        public static void SetAgentResult(this DataTable table)
        {
            Console.Write("Script completed. The SetAgentResult method will be executed when the script is executed on Agenty cloud");
        }

        public static void SetAgentInput(this DataTable table)
        {
            Console.Write("Script completed. The SetAgentInput method will be executed when the script is executed on Agenty cloud");
        }
        
        public static string Stringify(this object Obj, bool indent = false)
        {
            if (indent)
                return JsonConvert.SerializeObject(Obj, Formatting.Indented);
            else
                return JsonConvert.SerializeObject(Obj);
        }

        public static void Dump(this DataTable table)
        {
            string data = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (null != table && null != table.Rows)
            {
                foreach (DataRow dataRow in table.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        sb.Append(item);
                        sb.Append(',');
                    }
                    sb.AppendLine();
                }
                data = sb.ToString();
            }
            Console.WriteLine(data);
        }
    }
}
