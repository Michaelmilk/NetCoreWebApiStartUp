using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApiServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void ConfigurationTest()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").AddJsonFile("appsettings.1.json");

            IConfiguration configuration = builder.Build();

            Console.WriteLine(
            $"suboption1 = {configuration["Logging:LogLevel:Default"]}");

            Console.WriteLine(
           $"suboption1111 = {configuration["Logging:LogLevel1:Default"]}");

            Console.WriteLine(
            $"kk = {configuration["KK"]}");
        }
    }
}
