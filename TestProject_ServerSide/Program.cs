using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TestProject_ServerSide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(web_builder =>
                {
                    _ = web_builder.UseStartup<Startup>();
                });
    }
}