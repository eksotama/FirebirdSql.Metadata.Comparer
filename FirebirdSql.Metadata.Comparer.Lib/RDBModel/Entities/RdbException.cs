using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$EXCEPTIONS stores custom database exceptions.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-exceptions.html"/>
    /// </summary>
    public class RdbException
    {
        /// <summary>
        /// Custom exception name
        /// </summary>
        [MaxLength(31)]
        public string ExceptionName { get; set; }
        /// <summary>
        /// The unique number of the exception assigned by the system
        /// </summary>
        [Key]
        public int ExceptionNumber { get; set; }
        /// <summary>
        /// Exception message text
        /// </summary>
        [MaxLength(1021)]
        public string Message { get; set; }
        /// <summary>
        /// Could store text description of the exception
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Flag:
        /// user-defined = 0
        /// system-defined = 1 or higher
        /// </summary>
        public bool SystemFlag { get; set; }
    }
}
