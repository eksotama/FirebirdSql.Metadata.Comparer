using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class FunctionTests : RdbEntityTestBase<RdbFunction>
    {
        public FunctionTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
