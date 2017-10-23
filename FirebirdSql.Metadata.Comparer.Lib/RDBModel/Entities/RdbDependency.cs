using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$DEPENDENCIES stores the dependencies between database objects.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-dependencies.html"/>
    /// </summary>
    public class RdbDependency
    {
        /// <summary>
        /// The name of the view, procedure, trigger, CHECK constraint or computed column the dependency is defined for, i.e., the dependent object
        /// </summary>
        [MaxLength(31)]
        public string DependentName { get; set; }

        /// <summary>
        /// The name of the object that the defined object—the table, view, procedure, trigger, CHECK constraint or computed column—depends on
        /// </summary>
        [MaxLength(31)]
        public string DependedOnName { get; set; }

        /// <summary>
        /// The column name in the depended-on object that is referred to by the dependent view, procedure, trigger, CHECK constraint or computed column
        /// </summary>
        [MaxLength(31)]
        public string FieldName { get; set; }

        /// <summary>
        /// Identifies the type of the dependent object
        /// </summary>
        public short DependentType { get; set; }

        /// <summary>
        /// Identifies the type of the object depended on
        /// </summary>
        public short DependedOnType { get; set; }
    }
}
