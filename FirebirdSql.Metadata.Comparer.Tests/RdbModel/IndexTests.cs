using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class IndexTests : RdbEntityTestBase<RdbIndex>
    {
        public IndexTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
