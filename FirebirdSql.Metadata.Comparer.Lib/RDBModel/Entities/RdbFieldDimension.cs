using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FIELD_DIMENSIONS stores the dimensions of array columns.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-fielddims.html"/>
    /// </summary>
    public class RdbFieldDimension
    {
        /// <summary>
        /// The name of the array column. It must be present in the RDB$FIELD_NAME field of the RDB$FIELDS table
        /// </summary>
        [Key, MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// Identifies one dimension in the array column. The numbering of dimensions starts with 0
        /// </summary>
        public short Dimension { get; set; }

        /// <summary>
        /// The lower bound of this dimension
        /// </summary>
        public int LowerBound { get; set; }

        /// <summary>
        /// The upper bound of this dimension
        /// </summary>
        public int UpperBound { get; set; }
    }
}
