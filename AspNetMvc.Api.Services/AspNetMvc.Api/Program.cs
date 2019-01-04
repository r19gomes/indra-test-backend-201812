using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace AspNetMvc.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            // Register the Lamar service container
            //.UseLamar()
            // Your normal webhost config
            // .UseKestrel(c => c.AddServerHeader = false)
            // .UseIISIntegration()
            // .CaptureStartupErrors(true)
            .UseStartup<Startup>();
    }
}
