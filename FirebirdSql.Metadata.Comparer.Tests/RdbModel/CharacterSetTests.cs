using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class CharacterSetTests : RdbEntityTestBase<RdbCharacterSet>
    {
        public CharacterSetTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
