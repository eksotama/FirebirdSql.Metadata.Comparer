using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$SECURITY_CLASSES stores the access control lists
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-secclasses.html"/>
    /// </summary>
    public class RdbSecurityClass
    {
        /// <summary>
        /// Security class name
        /// </summary>
        [Key, MaxLength(31)]
        public string SecurityClass { get; set; }

        /// <summary>
        /// The access control list related to the security class. It enumerates users and their privileges
        /// </summary>
        public string Acl { get; set; }

        /// <summary>
        /// Could store comments related to the security class
        /// </summary>
        public string Description { get; set; }
    }
}
