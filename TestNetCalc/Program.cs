using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace TestNetCalc
{
    public class Program
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
              webBuilder.UseStartup<Startup>();
              webBuilder.ConfigureKestrel(KestrelServerOptions =>
              {
                  KestrelServerOptions.Limits.MaxConcurrentConnections = 1000;
                  KestrelServerOptions.Limits.MaxConcurrentUpgradedConnections = 1000;
                  KestrelServerOptions.Limits.Http2.MaxStreamsPerConnection = 1000;
                  KestrelServerOptions.Limits.MaxConcurrentUpgradedConnections = 1000;
              });
          });
    }
}
