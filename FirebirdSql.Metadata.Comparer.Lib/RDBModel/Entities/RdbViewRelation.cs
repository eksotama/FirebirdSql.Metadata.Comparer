using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$VIEW_RELATIONS stores the tables that are referred to in view definitions. There is one record for each table in a view.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-viewrelns.html"/>
    /// </summary>
    public class RdbViewRelation
    {
        /// <summary>
        /// View name
        /// </summary>
        [MaxLength(31)]
        public string ViewName { get; set; }

        /// <summary>
        /// The name of the table the view references
        /// </summary>
        [MaxLength(31)]
        public string RelationName { get; set; }

        /// <summary>
        /// The alias used to reference the view column in the BLR code of the query definition
        /// </summary>
        public short ViewContext { get; set; }

        /// <summary>
        /// The text associated with the alias reported in the RDB$VIEW_CONTEXT column
        /// </summary>
        [MaxLength(255)]
        public string ContextName { get; set; }
    }
}
