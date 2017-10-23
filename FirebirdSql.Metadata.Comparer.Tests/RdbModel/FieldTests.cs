﻿using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class FieldTests : RdbEntityTestBase<RdbField>
    {
        public FieldTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
