﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities
{
    /// <summary>
    /// RDB$REF_CONSTRAINTS stores the attributes of the referential constraints—Foreign Key relationships and referential actions.
    /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-refconstr.html"/>
    /// </summary>
    public class RdbRefConstraint
    {
        /// <summary>
        /// Foreign key constraint name, defined by the user or automatically generated by the system
        /// </summary>
        [Key, MaxLength(31)]
        public string ConstraintName { get; set; }

        /// <summary>
        /// The name of the primary or unique key constraint linked by the REFERENCES clause in the constraint definition
        /// </summary>
        [MaxLength(31)]
        public string ConstNameUq { get; set; }

        /// <summary>
        /// Not used. The current value is FULL in all cases
        /// </summary>
        [MaxLength(7)]
        public string MatchOption { get; set; }

        /// <summary>
        /// Referential integrity actions applied to the foreign key record[s] when the primary (unique) key of the parent table is updated: RESTRICT, NO ACTION, CASCADE, SET NULL, SET DEFAULT
        /// </summary>
        [MaxLength(11)]
        public string UpdateRule { get; set; }

        /// <summary>
        /// Referential integrity actions applied to th foreign key record[s] when the primary (unique) key of the parent table is deleted: RESTRICT, NO ACTION, CASCADE, SET NULL, SET DEFAULT
        /// </summary>
        [MaxLength(11)]
        public string DeleteRule { get; set; }
    }
}
