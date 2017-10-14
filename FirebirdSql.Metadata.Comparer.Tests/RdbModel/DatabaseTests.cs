using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class DatabaseTests : RdbEntityTestBase<RdbDatabase>
    {
        public DatabaseTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
