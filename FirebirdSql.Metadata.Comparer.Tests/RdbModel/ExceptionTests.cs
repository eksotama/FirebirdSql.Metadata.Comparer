using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class ExceptionTests : RdbEntityTestBase<RdbException>
    {
        public ExceptionTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
