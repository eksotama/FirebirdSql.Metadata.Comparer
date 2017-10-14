using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$COLLATIONS stores collation sequences for all character sets.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-collations.html"/>
    /// </summary>
    public class RdbCollation
    {
        /// <summary>
        /// Collation sequence name
        /// </summary>
        [MaxLength(31)]
        public string CollationName { get; set; }

        /// <summary>
        /// Collation sequence identifier. Together with the character set identifier, it is a unique collation sequence identifier
        /// </summary>
        public short CollationId { get; set; }

        /// <summary>
        /// Character set identifier. Together with the collection sequence identifier, it is a unique identifier
        /// </summary>
        public short CharacterSetId { get; set; }

        /// <summary>
        /// Collation attributes. 
        /// It is a bit mask where the first bit shows whether trailing spaces should be taken into account in collations (0 - NO PAD; 1 - PAD SPACE); 
        /// the second bit shows whether the collation is case-sensitive (0 - CASE SENSITIVE, 1 - CASE INSENSITIVE); 
        /// the third bit shows whether the collation is accent-sensitive (0 - ACCENT SENSITIVE, 1 - ACCENT SENSITIVE). 
        /// Thus, the value of 5 means that the collation does not take into account trailing spaces and is accent-insensitive
        /// </summary>
        public RdbCollationAttributes CollationAttributes { get; set; }

        /// <summary>
        /// Flag: the value of 0 means it is user-defined; the value of 1 means it is system-defined
        /// </summary>
        public bool SystemFlag { get; set; }

        /// <summary>
        /// Could store text description of the collation sequence
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Not currently used
        /// </summary>
        [MaxLength(31)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The name of the base collation sequence for this collation sequence
        /// </summary>
        [MaxLength(31)]
        public string BaseCollationName { get; set; }

        /// <summary>
        /// Describes specific attributes
        /// </summary>
        public string SpecificAttributes { get; set; }
    }
    [Flags]
    public enum RdbCollationAttributes
    {
        None = 0,
        /// <summary>
        /// Trailing spaces should be taken into account in collations
        /// </summary>
        PadSpace = 1,
        /// <summary>
        /// Collation is case-sensitive
        /// </summary>
        CaseInsensitive = 2,
        /// <summary>
        /// Collation is accent-sensitive
        /// </summary>
        AccentSensitive = 4
    }
}
