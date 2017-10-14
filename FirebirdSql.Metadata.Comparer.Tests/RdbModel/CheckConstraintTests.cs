﻿using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class CheckConstraintTests : RdbEntityTestBase<RdbCheckConstraint>
    {
        public CheckConstraintTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
