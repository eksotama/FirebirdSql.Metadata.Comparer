using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    public class RdbCheckConstraint
    {
        [Key, MaxLength(31)]
        public string ConstraintName { get; set; }

        [MaxLength(31)]
        public string TriggerName { get; set; }
    }
}
