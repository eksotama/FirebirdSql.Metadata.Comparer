using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$RELATIONS stores the top-level definitions and attributes of all tables and views in the system.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-relations.html"/>
    /// </summary>
    public class RdbRelation
    {
        /// <summary>
        /// Stores the query specification for a view, in the binary language representation (BLR). The field stores NULL for a table
        /// </summary>
        public byte[] ViewBlr { get; set; }

        /// <summary>
        /// Contains the original source text of the query for a view, in SQL language. User comments are included. The field stores NULL for a table
        /// </summary>
        public string ViewSource { get; set; }

        /// <summary>
        /// Could store comments related to the table or view
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Internal identifier of the table or view
        /// </summary>
        public short RelationId { get; set; }

        /// <summary>
        /// indicates whether the table or view is user-defined (value 0) or system-defined (value 1 or greater)
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// The total length of the database key. For a table: 8 bytes. For a view, the length is 8 multiplied by the number of tables referenced by the view
        /// </summary>
        public short DbkeyLength { get; set; }

        /// <summary>
        /// Internal use, points to the relation's record in RDB$FORMATS—do not modify
        /// </summary>
        public short Format { get; set; }

        /// <summary>
        /// The field ID for the next column to be added. The number is not decremented when a column is dropped.
        /// </summary>
        public short FieldId { get; set; }

        /// <summary>
        /// Table or view name
        /// </summary>
        [Key, MaxLength(31)]
        public string RelationName { get; set; }

        /// <summary>
        /// May reference a security class defined in the table RDB$SECURITY_CLASSES, in order to apply access control limits to all users of this table or view
        /// </summary>
        [MaxLength(31)]
        public string SecurityClass { get; set; }

        /// <summary>
        /// The full path to the external data file if the table is defined with the EXTERNAL FILE clause
        /// </summary>
        [MaxLength(255)]
        public string ExternalFile { get; set; }

        /// <summary>
        /// Table metadata description, used internally for optimization
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Could store comments related to the external file of an external table
        /// </summary>
        public string ExternalDescription { get; set; }

        /// <summary>
        /// The user name of the user who created the table or view originally
        /// </summary>
        [MaxLength(31)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Default security class, used when a new column is added to the table
        /// </summary>
        [MaxLength(31)]
        public string DefaultClass { get; set; }

        /// <summary>
        /// Internal flags
        /// </summary>
        public short? Flags { get; set; }

        /// <summary>
        /// The type of the relation object being described:
        /// 0 - system or user-defined table
        /// 1 - view
        /// 2 - external table
        /// 3 - monitoring table
        /// 4 - connection-level GTT(PRESERVE ROWS)
        /// 5 - transaction-level GTT(DELETE ROWS)
        /// </summary>
        public short RelationType { get; set; }
    }
}
