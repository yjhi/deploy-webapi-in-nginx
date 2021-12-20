using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APITemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            string baseAddress = Config.Server;
                                                          // string baseAddress = "http://192.168.0.52:3070/";
            using (Microsoft.Owin.Hosting.WebApp.Start<StartUp>(url: baseAddress))
            {
                HttpClient client = new HttpClient();
                Console.WriteLine(baseAddress);
                Console.ReadLine();

            }
        }
    }
}
