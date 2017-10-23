using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.Model.Enums
{
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
