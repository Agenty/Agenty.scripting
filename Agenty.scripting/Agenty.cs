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
            public static DataTable GetAgentInput(string agentId)
            {
                if(string.IsNullOrEmpty(ApiKey))
                {
                    throw new AgentyException($"ApiKey is not set. Use the Agenty.ApiKey = [your api key] to set your api key first");
                }
                return null;
            }

            public static DataTable GetAgentResult(string agentId, int? Version = null, int Collection = 1, bool Modified = false)
            {
                if (string.IsNullOrEmpty(ApiKey))
                {
                    throw new AgentyException($"ApiKey is not set. Use the Agenty.ApiKey = [your api key] to set your api key first");
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
    }
}
