using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$BACKUP_HISTORY stores the history of backups performed using the nBackup utility.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-backuphistory.html"/>
    /// </summary>
    public class RdbBackupHistory
    {
        /// <summary>
        /// The identifier assigned by the engine
        /// </summary>
        [Key]
        public int BackupId { get; set; }

        /// <summary>
        /// Backup date and time
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Backup level
        /// </summary>
        public int BackupLevel { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        [MaxLength(38)]
        public string Guid { get; set; }

        /// <summary>
        /// System (scan) number
        /// </summary>
        public int Scn { get; set; }

        /// <summary>
        /// Full path and file name of backup file
        /// </summary>
        [MaxLength(255)]
        public string FileName { get; set; }
    }
}
