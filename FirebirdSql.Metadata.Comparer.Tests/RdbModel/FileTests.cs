using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class FileTests : RdbEntityTestBase<RdbFile>
    {
        public FileTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
