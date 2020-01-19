using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace Core.EntityFrameWork
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateWebHostBuilder(args).Run();
        //}

        //public static IWebHost CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .UseDefaultServiceProvider(options=>options.ValidateScopes=false)
        //        .Build();

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options=>options.ValidateScopes=false)
                .Build();

    }
}
