# apitemplate

Deploy webapi server in windows server.
The foreground agent can use nginx.




Install-Package Microsoft.AspNet.WebApi.OwinSelfHost



 class Program
    {
        static void Main(string[] args)
        {
            string baseurl = "http://127.0.0.1:8063";

            WebApp.Start<StartUp>(url: baseurl);
            Console.WriteLine("Server Running...");
            Console.WriteLine(baseurl);

            Console.ReadLine();

        }


       
    }

   public  class  StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration cfg = new HttpConfiguration();

            cfg.Routes.MapHttpRoute(
                name:"Api",
                routeTemplate:"api/{controller}/{id}",
                defaults:new { id=RouteParameter.Optional}
                );

            app.UseWebApi(cfg);
        }
    }
