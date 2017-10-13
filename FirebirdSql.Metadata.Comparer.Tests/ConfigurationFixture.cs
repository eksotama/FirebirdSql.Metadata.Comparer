using EntityFrameworkCore.FirebirdSql.Extensions;
using FirebirdSql.Metadata.Comparer.Lib.RDBModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FirebirdSql.Metadata.Comparer.Tests.RdbModel;

namespace FirebirdSql.Metadata.Comparer.Tests
{
    public class ConfigurationFixture
    {
        public IServiceProvider provider { get; private set; }

        public ConfigurationFixture()
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            IServiceCollection services = new ServiceCollection();
            services.AddEntityFrameworkFirebird()
                .AddDbContext<FirebirdRdbContext>(opt => opt.UseFirebird(string.Format(config["Database:ConnectionString"], "employee.fdb")));
            provider = services.BuildServiceProvider();
        }
    }
}
