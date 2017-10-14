using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Tests.RdbModel
{
    public class BackupHistoryTests : RdbEntityTestBase<RdbBackupHistory>
    {
        public BackupHistoryTests(ConfigurationFixture fixture) : base(fixture)
        {
        }
    }
}
