using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    public class RdbDatabase
    {
        /// <summary>
        /// Database comment text
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A number that steps up by one each time a table or view is added to the database
        /// </summary>
        [Key]
        public short RelationId { get; set; }

        /// <summary>
        /// The security class defined in RDB$SECURITY_CLASSES in order to apply access control limits common to the entire database
        /// </summary>
        [MaxLength(31)]
        public string SecurityClass { get; set; }

        /// <summary>
        /// The name of the default character set for the database set in the DEFAULT CHARACTER SET clause when the database is created. 
        /// NULL for character set NONE.
        /// </summary>
        [MaxLength(31)]
        public string CharacterSetName { get; set; }
    }
}
