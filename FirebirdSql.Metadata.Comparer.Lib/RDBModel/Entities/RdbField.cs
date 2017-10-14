using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FIELDS stores definitions of columns and domains, both system and custom. This is where the detailed data attributes are stored for all columns.
    /// 
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-fields.html"/>
    /// </summary>
    /// <remarks>
    /// The column RDB$FIELDS.RDB$FIELD_NAME links to RDB$RELATION_FIELDS.RDB$FIELD_SOURCE, not to RDB$RELATION_FIELDS.RDB$FIELD_NAME.
    /// </remarks>
    public class RdbField
    {
        /// <summary>
        /// The unique name of the domain created by the user or of the domain automatically built for the table column by the system. System-created domain names start with the 'RDB$' prefix
        /// </summary>
        [Key, MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        [MaxLength(31)]
        public string QueryName { get; set; }

        /// <summary>
        /// The binary language representation (BLR) of the SQL expression specifying the check of the CHECK value in the domain
        /// </summary>
        public byte[] ValidationBlr { get; set; }

        /// <summary>
        /// The original source text in the SQL language specifying the check of the CHECK value
        /// </summary>
        public string ValidationSource { get; set; }

        /// <summary>
        /// The binary language representation (BLR) of the SQL expression the database server uses for evaluation when accessing a COMPUTED BY column
        /// </summary>
        public byte[] ComputedBlr { get; set; }

        /// <summary>
        /// The original source text of the expression that defines a COMPUTED BY column
        /// </summary>
        public string ComputedSource { get; set; }

        /// <summary>
        /// The default value, if any, for the field or domain, in binary language representation (BLR)
        /// </summary>
        public byte[] DefaultValue { get; set; }

        /// <summary>
        /// The default value in the source code, as an SQL constant or expression
        /// </summary>
        public string DefaultSource { get; set; }

        /// <summary>
        /// Column size in bytes. FLOAT, DATE, TIME, INTEGER occupy 4 bytes. DOUBLE PRECISION, BIGINT, TIMESTAMP and BLOB identifier occupy 8 bytes. For the CHAR and VARCHAR data types, the column stores the maximum number of bytes specified when a string domain (column) is defined
        /// </summary>
        public short FieldLength { get; set; }

        /// <summary>
        /// The negative number that specifies the scale for DECIMAL and NUMERIC columns—the number of digits after the decimal point
        /// </summary>
        public short FieldScale { get; set; }

        /// <summary>
        /// Data type code for the column
        /// </summary>
        public RdbFieldType FieldType { get; set; }

        /// <summary>
        /// Specifies the subtype
        /// </summary>
        public short? FieldSubType { get; set; }

        /// <summary>
        /// Evaluate subtype enum based on base field type
        /// </summary>
        [NotMapped]
        public dynamic FieldSubTypeNamed
        {
            get
            {
                switch (FieldType)
                {
                    case RdbFieldType.BLOB:
                        return (RdbFieldBlobSubtype)FieldSubType;
                    case RdbFieldType.CHAR:
                        return (RdbFieldCharSubtype)FieldSubType;
                    case RdbFieldType.SMALLINT:
                    case RdbFieldType.INTEGER:
                    case RdbFieldType.BIGINT:
                        return (RdbFieldIntegerSubtype)(FieldSubType ?? 0);
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Not used
        /// </summary>
        public byte[] MissingValue { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        public string MissingSource { get; set; }

        /// <summary>
        /// Any domain (table column) comment text
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Flag: the value of 1 means the domain is automatically created by the system, the value of 0 means that the domain is defined by the user
        /// </summary>
        public short SystemFlag { get; set; }

        [NotMapped]
        public bool IsUserDefined
        {
            get
            {
                return SystemFlag == 0;
            }
        }

        /// <summary>
        /// Not used
        /// </summary>
        public string QueryHeader { get; set; }

        /// <summary>
        /// Specifies the length of the BLOB buffer in bytes for BLOB columns. Stores NULL for all other data types
        /// </summary>
        public short? SegmentLength { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        [MaxLength(127)]
        public string EditString { get; set; }

        /// <summary>
        /// The length of the column in bytes if it belongs to an external table. Always NULL for regular tables
        /// </summary>
        public short? ExternalLength { get; set; }

        /// <summary>
        /// The scale factor of an integer-type field in an external table; represents the power of 10 by which the integer is multiplied
        /// </summary>
        public short? ExternalScale { get; set; }

        /// <summary>
        /// The data type of the field as it is represented in an external table
        /// </summary>
        public RdbFieldType? ExternalType { get; set; }

        /// <summary>
        /// Defines the number of dimensions in an array if the column is defined as an array. Always NULL for columns that are not arrays
        /// </summary>
        public short? Dimensions { get; set; }

        /// <summary>
        /// Specifies whether the column can take an empty value (the field will contain NULL) or not (the field will contain the value of 1)
        /// </summary>
        public short? NullFlag { get; set; }

        [NotMapped]
        public bool IsNullable
        {
            get
            {
                return NullFlag == null;
            }
        }

        /// <summary>
        /// The length of CHAR or VARCHAR columns in characters (not in bytes)
        /// </summary>
        public short? CharacterLength { get; set; }

        /// <summary>
        /// The identifier of the collation sequence for a character column or domain. If it is not defined, the value of the field will be 0
        /// </summary>
        public short? CollationId { get; set; }

        public bool IsCollationDefined
        {
            get
            {
                return (CollationId ?? 0) != 0;
            }
        }

        /// <summary>
        /// The identifier of the character set for a character column, BLOB TEXT column or domain
        /// </summary>
        public short? CharacterSetId { get; set; }

        public bool IsCharacterSetDefined
        {
            get
            {
                return (CharacterSetId ?? 0) != 0;
            }
        }

        /// <summary>
        /// Specifies the total number of digits for the fixed-point numeric data type (DECIMAL and NUMERIC). The value is 0 for the integer data types, NULL is for other data types
        /// </summary>
        public short? FieldPrecision { get; set; }
    }

    public enum RdbFieldType
    {
        SMALLINT = 7,
        INTEGER = 8,
        FLOAT = 10,
        DATE = 12,
        TIME = 13,
        CHAR = 14,
        BIGINT = 16,
        DOUBLE_PRECISION = 27,
        TIMESTAMP = 35,
        VARCHAR = 37,
        BLOB = 261
    }

    public enum RdbFieldBlobSubtype
    {
        UNTYPED = 0,
        TEXT,
        BLR,
        ACCESS_CONTROL_LIST,
        RESERVED,
        ENCODED_TABLE_METADATA_DESCRIPTION,
        CROSS_DATABASE_TRANSACTION_DETAILS
    }

    public enum RdbFieldCharSubtype
    {
        UNTYPED = 0,
        BINARY
    }

    public enum RdbFieldIntegerSubtype
    {
        SELF = 0,
        NUMERIC,
        DECIMAL
    }
}
