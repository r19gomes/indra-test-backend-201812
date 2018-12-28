using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1
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
            .UseLamar()
            // Your normal webhost config
            .UseKestrel(c => c.AddServerHeader = false)
            .UseIISIntegration()
            .UseStartup<Startup>()
            .CaptureStartupErrors(true);
    }
}
