using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class RelationConstraintTests : RdbEntityTestBase<RdbRelationConstraint>
    {
        public RelationConstraintTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
