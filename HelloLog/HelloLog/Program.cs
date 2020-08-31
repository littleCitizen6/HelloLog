//using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;

namespace HelloLog
{
    class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(configuration)
                    .CreateLogger();
            Log.Information("Hello Serilog!");
        }
    }
}
