using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.Model.Enums
{
    [Flags]
    public enum CollationAttributes
    {
        None = 0,
        /// <summary>
        /// Trailing spaces should be taken into account in collations
        /// </summary>
        PadSpace = 1,
        /// <summary>
        /// Collation is case-sensitive
        /// </summary>
        CaseInsensitive = 2,
        /// <summary>
        /// Collation is accent-sensitive
        /// </summary>
        AccentSensitive = 4
    }
}
