using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$RELATION_FIELDS stores the definitions of table and view columns.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-relfields.html"/>
    /// </summary>
    public class RdbRelationField
    {
        /// <summary>
        /// Column name
        /// </summary>
        [MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// The name of the table or view that the column belongs to
        /// </summary>
        [MaxLength(31)]
        public string RelationName { get; set; }

        /// <summary>
        /// Domain name on which the column is based, either a user-defined one specified in the table definition or one created automatically by the system using the set of attributes defined. The attributes are in the table RDB$FIELDS: this column matches RDB$FIELDS.RDB$FIELD_NAME.
        /// </summary>
        [MaxLength(31)]
        public string FieldSource { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        [MaxLength(31)]
        public string QueryName { get; set; }

        /// <summary>
        /// Only populated for a view, it is the name of the column from the base table
        /// </summary>
        [MaxLength(31)]
        public string BaseField { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        [MaxLength(127)]
        public string EditString { get; set; }

        /// <summary>
        /// The zero-based ordinal position of the column in the table or view, numbering from left to right
        /// </summary>
        public short FieldPosition { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        public string QueryHeader { get; set; }

        /// <summary>
        /// Indicates whether the column is a regular one (value 1) or a computed one (value 0)
        /// </summary>
        public short UpdateFlag { get; set; }

        /// <summary>
        /// An ID assigned from RDB$RELATIONS.RDB$FIELD_ID at the time the column was added to the table or view. It should always be treated as transient
        /// </summary>
        public short FieldId { get; set; }

        /// <summary>
        /// For a view column, the internal identifier of the base table from which this field derives
        /// </summary>
        public short? ViewContext { get; set; }

        /// <summary>
        /// Comments related to the table or view column
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The value stored for the DEFAULT clause for this column, if there is one, written in binary language representation (BLR)
        /// </summary>
        public byte[] DefaultValue { get; set; }

        /// <summary>
        /// Indicates whether the column is user-defined (value 0) or system-defined (value 1 or greater)
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// May reference a security class defined in RDB$SECURITY_CLASSES, in order to apply access control limits to all users of this column
        /// </summary>
        [MaxLength(31)]
        public string SecurityClass { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        [MaxLength(31)]
        public string ComplexName { get; set; }

        /// <summary>
        /// Indicates whether the column is nullable (NULL) non-nullable (value 1)
        /// </summary>
        public short? NullFlag { get; set; }

        /// <summary>
        /// The source text of the DEFAULT clause, if any
        /// </summary>
        public string DefaultSource { get; set; }

        /// <summary>
        /// The identifier of the collation sequence in the character set for the column, if it is not the default collation
        /// </summary>
        public short? CollationId { get; set; }
    }
}