using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHost(args);
        }

        private static void CreateHost(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
