using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FirebirdSql.Metadata.Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            Console.WriteLine(config["Database:ConnectionString"]);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
