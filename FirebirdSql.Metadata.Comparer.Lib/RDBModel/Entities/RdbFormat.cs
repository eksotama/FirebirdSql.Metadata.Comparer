using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FORMATS stores information about changes in tables. Each time any metadata change to a table is committed, it gets a new format number. 
    /// When the format number of any table reaches 255, the entire database becomes inoperable. 
    /// To return to normal, the database must be backed up with the gbak utility and restored from that backup copy.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-formats.html"/>
    /// </summary>
    public class RdbFormat
    {
        /// <summary>
        /// Table or view identifier
        /// </summary>
        [Key]
        public short RelationId { get; set; }

        /// <summary>
        /// Table format identifier—maximum 255. The critical time comes when this number approaches 255 for any table or view
        /// </summary>
        public short Format { get; set; }

        /// <summary>
        /// Stores column names and data attributes as BLOB, as they were at the time the format record was created
        /// </summary>
        public string Descriptor { get; set; }
    }
}
