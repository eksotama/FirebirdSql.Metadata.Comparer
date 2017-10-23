using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$GENERATORS stores generators (sequences) and keeps them up-to-date.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-generators.html"/>
    /// </summary>
    public class RdbGenerator
    {
        /// <summary>
        /// The unique name of the generator
        /// </summary>
        [Key, MaxLength(31)]
        public string GeneratorName { get; set; }

        /// <summary>
        /// The unique identifier assigned to the generator by the system
        /// </summary>
        public short GeneratorId { get; set; }

        /// <summary>
        /// Flag:
        /// 0 = user-defined
        /// 1 or greater = system - defined
        /// </summary>
        public short SystemFlag { get; set; }

        /// <summary>
        /// Could store comments related to the generator
        /// </summary>
        public string Description { get; set; }
    }
}
