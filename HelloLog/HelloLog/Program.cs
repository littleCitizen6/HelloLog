//using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace HelloLog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
            Log.Information("Hello Serilog!");
        }
    }
}
