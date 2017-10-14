using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class CollationTests : RdbEntityTestBase<RdbCollation>
    {
        public CollationTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
