using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
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
        public DependencyType DependentType { get; set; }

        /// <summary>
        /// Identifies the type of the object depended on
        /// </summary>
        public DependencyType DependedOnType { get; set; }
    }

    public enum DependencyType
    {
        Table = 0,
        View = 1,
        Trigger = 2,
        ComputedColumn = 3,
        CheckConstraint = 4,
        Procedure = 5,
        IndexExpression = 6,
        Exception = 7,
        User = 8,
        Column = 9,
        Index = 10,
        Generator = 14,
        UDF = 15,
        Collation = 17
    }
}
