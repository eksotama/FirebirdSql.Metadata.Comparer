using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$CHARACTER_SETS names and describes the character sets available in the database.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-charactersets.html"/>
    /// </summary>
    public class RdbCharacterSet
    {
        /// <summary>
        /// Character set name
        /// </summary>
        [MaxLength(31)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// Not used
        /// </summary>
        [MaxLength(31)]
        public string FormOfUse { get; set; }

        /// <summary>
        /// The number of characters in the set. Not used for existing character sets
        /// </summary>
        public int? NumberOfCharacters { get; set; }

        /// <summary>
        /// The name of the default collation sequence for the character set
        /// </summary>
        [MaxLength(31)]
        public string DefaultCollateName { get; set; }

        /// <summary>
        /// Unique character set identifier
        /// </summary>
        [Key]
        public short CharacterSetId { get; set; }

        /// <summary>
        /// System flag: value is 1 if the character set is defined in the system when the database is created; value is 0 for a user-defined character set
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// Could store text description of the character set
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// For a user-defined character set that is accessed via an external function, the name of the external function
        /// </summary>
        [MaxLength(31)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The maximum number of bytes representing one character
        /// </summary>
        public short BytesPerCharacter { get; set; }
    }
}
