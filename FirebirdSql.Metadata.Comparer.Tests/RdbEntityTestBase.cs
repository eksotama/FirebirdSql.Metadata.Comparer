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
        public DbSet<T> Set;

        public RdbEntityTestBase(ConfigurationFixture fixture)
        {
            db = fixture.Provider.GetRequiredService<FirebirdRdbContext>();
            Set = db.Set<T>();
            Assert.NotNull(Set);
        }

        [Fact]
        public void GetEntityTest()
        {
            if (Set.Count() > 0)
            {
                var element = Set.First();
                Assert.NotNull(element);
            }
        }
    }
}
