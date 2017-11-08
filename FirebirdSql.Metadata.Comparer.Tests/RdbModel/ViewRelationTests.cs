using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class ViewRelationTests : RdbEntityTestBase<RdbViewRelation>
    {
        public ViewRelationTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
