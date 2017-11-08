using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$INDEX_SEGMENTS stores the segments (table columns) of indexes and their positions in the key. A separate row is stored for each column in an index.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-idxsegments.html"/>
    /// </summary>
    public class RdbIndexSegment
    {
        /// <summary>
        /// The name of the index this segment is related to. The master record is RDB$INDICES.RDB$INDEX_NAME.
        /// </summary>
        [MaxLength(31)]
        public string IndexName { get; set; }

        /// <summary>
        /// 	The name of a column belonging to the index, corresponding to an identifier for the table and that column in RDB$RELATION_FIELDS.RDB$FIELD_NAME
        /// </summary>
        [MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// The column position in the index. Positions are numbered left-to-right, starting at zero
        /// </summary>
        public short FieldPosition { get; set; }

        /// <summary>
        /// The last known (calculated) selectivity of this column in the index. The higher the number, the lower the selectivity.
        /// </summary>
        public double? Statistics { get; set; }
    }
}
