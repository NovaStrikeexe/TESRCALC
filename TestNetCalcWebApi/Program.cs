using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace TestNetCalcWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    /*public class Program
    {

        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                services.Configure<KestrelServerOptions>(
                    context.Configuration.GetSection("Kestrel"));
            })
          .ConfigureWebHostDefaults(webBuilder =>
          {
              webBuilder.UseKestrel();
              webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
              webBuilder.UseStartup<Startup>();
              webBuilder.ConfigureKestrel(KestrelServerOptions =>
              {
                  KestrelServerOptions.Limits.Http2.MaxStreamsPerConnection = 10;
                  KestrelServerOptions.Limits.MaxConcurrentConnections = 10;
                  KestrelServerOptions.Limits.MaxConcurrentUpgradedConnections = 10;
              });

          });
        
    }*/
}
