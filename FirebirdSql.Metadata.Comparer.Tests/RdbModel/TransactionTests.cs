using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class TransactionTests : RdbEntityTestBase<RdbTransaction>
    {
        public TransactionTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
