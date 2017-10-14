using FirebirdSql.Metadata.Comparer.Lib.RDBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace FirebirdSql.Metadata.Comparer.Tests
{

    public abstract class RdbEntityTestBase<T> : IClassFixture<ConfigurationFixture> where T : class
    {
        FirebirdRdbContext db;
        DbSet<T> set;

        public RdbEntityTestBase(ConfigurationFixture fixture)
        {
            db = fixture.Provider.GetRequiredService<FirebirdRdbContext>();
            set = db.Set<T>();
            Assert.NotNull(set);
        }

        [Fact]
        public void GetEntityTest()
        {
            if (set.Count() > 0)
            {
                var element = set.First();
                Assert.NotNull(element);
            }
        }
    }
}
