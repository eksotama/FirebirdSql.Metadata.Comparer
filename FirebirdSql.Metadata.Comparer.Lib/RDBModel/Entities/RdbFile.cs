using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FILES stores information about secondary files and shadow files.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-files.html"/>
    /// </summary>
    public class RdbFile
    {
        /// <summary>
        /// The full path to the file and the name of either 
        ///     the database secondary file in a multi-file database, 
        ///     or the shadow file
        /// </summary>
        [Key, MaxLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// The sequential number of the secondary file in a sequence or of the shadow file in a shadow file set
        /// </summary>
        public short FileSequence { get; set; }

        /// <summary>
        /// The initial page number in the secondary file or shadow file
        /// </summary>
        public int FileStart { get; set; }

        /// <summary>
        /// File length in database pages
        /// </summary>
        public int FileLength { get; set; }

        /// <summary>
        /// For internal use
        /// </summary>
        public short FileFlags { get; set; }

        /// <summary>
        /// Shadow set number. If the row describes a database secondary file, the field will be NULL or its value will be 0
        /// </summary>
        public short? ShadowNumber { get; set; }
    }
}
