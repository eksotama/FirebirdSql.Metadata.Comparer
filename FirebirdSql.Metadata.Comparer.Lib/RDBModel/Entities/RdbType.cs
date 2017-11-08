using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$TYPES stores the defining sets of enumerated types used throughout the system.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-types.html"/>
    /// </summary>
    public class RdbType
    {
        /// <summary>
        /// Enumerated type name. Each type name masters its own set of types, e.g., object types, data types, character sets, trigger types, blob subtypes, etc.
        /// </summary>
        [Key, MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// The object type identifier. A unique series of numbers is used within each separate enumerated type. 
        /// For example, in this selection from the set mastered under RDB$OBJECT_TYPE in RDB$FIELD_NAME, 
        /// some object types are enumerated:
        /// 0 - TABLE
        /// 1 - VIEW
        /// 2 - TRIGGER
        /// 3 - COMPUTED_FIELD
        /// 4 - VALIDATION
        /// 5 - PROCEDURE
        /// ...
        /// </summary>
        public short Type { get; set; }

        /// <summary>
        /// The name of a member of an enumerated type, e.g., TABLE, VIEW, TRIGGER, etc. in the example above. In the RDB$CHARACTER_SET enumerated type, RDB$TYPE_NAME stores the names of the character sets.
        /// </summary>
        [MaxLength(31)]
        public string TypeName { get; set; }

        /// <summary>
        /// Any text comments related to the enumerated type
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Flag: indicates whether the type-member is user-defined (value 0) or system-defined (value 1 or greater)
        /// </summary>
        public short SystemFlag { get; set; }
    }
}
