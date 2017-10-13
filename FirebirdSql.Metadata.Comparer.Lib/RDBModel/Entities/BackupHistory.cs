using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    public class BackupHistory
    {
        [Key]
        public int BackupId { get; set; }

        public DateTime Timestamp { get; set; }

        public int BackupLevel { get; set; }

        [MaxLength(38)]
        public string Guid { get; set; }

        public int Scn { get; set; }

        [MaxLength(255)]
        public string FileName { get; set; }
    }
}
