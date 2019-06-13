using System;
using System.Collections.Generic;
using System.Data;
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
            Agenty.ApiKey = "AGENTY_API_KEY";

            // Get agent result as DataTable
            var table = Agenty.Cloud.GetAgentResult("<AGENT_ID>");

            // Write your code here to test

            // Print the table
            table.Dump();

            // Do not close the console
            Console.Read();
        }
    }
}
