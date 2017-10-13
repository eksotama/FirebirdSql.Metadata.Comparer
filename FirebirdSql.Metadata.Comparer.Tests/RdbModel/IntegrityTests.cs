using FirebirdSql.Metadata.Comparer.Lib.RDBModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{

    public class IntegrityTests : IClassFixture<ConfigurationFixture>
    {
        FirebirdRdbContext db;

        public IntegrityTests(ConfigurationFixture fixture)
        {
            db = fixture.provider.GetRequiredService<FirebirdRdbContext>();
        }

        [Fact]
        public void BackupHistoryTest()
        {
            var set = db.BackupHistory;
            Assert.NotNull(set);

            if(set.Count() > 0)
            {
                var element = set.First();
                Assert.NotNull(element);
            }
        }

        [Fact]
        public void CharacterSetsTest()
        {
            var set = db.CharacterSets;
            Assert.NotNull(set);

            if (set.Count() > 0)
            {
                var element = set.First();
                Assert.NotNull(element);
            }
        }
    }
}
