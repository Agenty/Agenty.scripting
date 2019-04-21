using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentyScripting;

namespace AgentyScriptingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set your api key
            Agenty.ApiKey = "myapikey";

            // Get agent result as DataTable
            var table = Agenty.Cloud.GetAgentInput("abc");     
            
            // Test your code
        }
    }
}
