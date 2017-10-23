using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$FUNCTION_ARGUMENTS stores the parameters of external functions and their attributes.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-funcargs.html"/>
    /// </summary>
    public class RdbFunctionArgument
    {
        /// <summary>
        /// The unique name (declared identifier) of the external function
        /// </summary>
        [MaxLength(31)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The position of the argument in the list of arguments
        /// </summary>
        public short ArgumentPosition { get; set; }

        /// <summary>
        /// Flag: how this argument is passed:
        /// 0 = by value
        /// 1 = by reference
        /// 2 = by descriptor
        /// 3 = by BLOB descriptor
        /// </summary>
        public short Mechanism { get; set; }

        /// <summary>
        /// Data type code defined for the column
        /// </summary>
        public short FieldType { get; set; }

        /// <summary>
        /// The scale of an integer or a fixed-point argument. It is an exponent of 10
        /// </summary>
        public short FieldScale { get; set; }

        /// <summary>
        /// Argument length in bytes:
        ///         SMALLINT = 2
        ///         INTEGER = 4
        ///         DATE = 4
        ///         TIME = 4
        ///         BIGINT = 8
        ///         DOUBLE PRECISION = 8
        ///         TIMESTAMP = 8
        ///         BLOB_ID = 8
        /// </summary>
        public short FieldLength { get; set; }

        /// <summary>
        /// Stores the BLOB subtype for an argument of a BLOB data type
        /// </summary>
        public short FieldSubType { get; set; }

        /// <summary>
        /// The identifier of the character set for a character argument
        /// </summary>
        public short? CharacterSetId { get; set; }

        /// <summary>
        /// The number of digits of precision available for the data type of the argument
        /// </summary>
        public short FieldPrecision { get; set; }

        /// <summary>
        /// The length of a CHAR or VARCHAR argument in characters (not in bytes)
        /// </summary>
        public short CharacterLength { get; set; }
    }
}
