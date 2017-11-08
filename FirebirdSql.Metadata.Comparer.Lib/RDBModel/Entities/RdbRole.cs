using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$ROLES stores the roles that have been defined in this database.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-roles.html"/>
    /// </summary>
    public class RdbRole
    {
        /// <summary>
        /// Role name
        /// </summary>
        [Key, MaxLength(31)]
        public string RoleName { get; set; }

        /// <summary>
        /// The user name of the role owner
        /// </summary>
        [MaxLength(31)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Could store comments related to the role
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// System flag
        /// </summary>
        public short SystemFlag { get; set; }
    }
}
