using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$PAGES stores and maintains information about database pages and their usage.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-pages.html"/>
    /// </summary>
    public class RdbPage
    {
        /// <summary>
        /// The unique number of a physically created database page
        /// </summary>
        [Key]
        public int PageNumber { get; set; }

        /// <summary>
        /// The identifier of the table to which the page is allocated
        /// </summary>
        public short RelationId { get; set; }

        /// <summary>
        /// The number of the page in the sequence of all pages allocated to this table
        /// </summary>
        public int PageSequence { get; set; }

        /// <summary>
        /// Indicates the page type (data, index, BLOB, etc.). For system use
        /// </summary>
        public short PageType { get; set; }
    }
}
