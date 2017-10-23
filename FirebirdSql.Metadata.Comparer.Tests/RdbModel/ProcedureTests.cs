using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class ProcedureTests : RdbEntityTestBase<RdbProcedure>
    {
        public ProcedureTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
