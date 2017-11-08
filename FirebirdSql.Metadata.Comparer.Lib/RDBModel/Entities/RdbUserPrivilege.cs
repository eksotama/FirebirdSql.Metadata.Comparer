using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$USER_PRIVILEGES stores the SQL access privileges for Firebird users and privileged objects.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-userprivs.html"/>
    /// </summary>
    public class RdbUserPrivilege
    {
        /// <summary>
        /// The user or object that is granted this privilege
        /// </summary>
        [MaxLength(31)]
        public string User { get; set; }

        /// <summary>
        /// The user who grants the privilege
        /// </summary>
        [MaxLength(31)]
        public string Grantor { get; set; }

        /// <summary>
        /// The privilege granted hereby:
        /// A - all(all privileges)
        /// S - select(selecting data)
        /// I - insert(inserting rows)
        /// D - delete(deleting rows)
        /// R - references(foreign key)
        /// U - update(updating data)
        /// E - executing(procedure)
        /// </summary>
        [MaxLength(6)]
        public string Privilege { get; set; }

        /// <summary>
        /// Whether the WITH GRANT OPTION authority is included with the privilege:
        /// 1 - included
        /// 0 - not included
        /// </summary>
        public short GrantOption { get; set; }

        /// <summary>
        /// The name of the object (table, view, procedure or role) the privilege is granted ON
        /// </summary>
        [MaxLength(31)]
        public string RelationName { get; set; }

        /// <summary>
        /// The name of the column the privilege is applicable to, for a column-level privilege (an UPDATE or REFERENCES privilege)
        /// </summary>
        [MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// Identifies the type of user the privilege is granted TO (a user, a procedure, a view, etc.)
        /// </summary>
        public short UserType { get; set; }

        /// <summary>
        /// Identifies the type of the object the privilege is granted ON
        /// </summary>
        public short ObjectType { get; set; }
    }
}
