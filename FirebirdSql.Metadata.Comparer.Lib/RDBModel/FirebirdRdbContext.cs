using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FirebirdSql.Metadata.Comparer.Lib.RDBModel.Entities;
using EntityFrameworkCore.FirebirdSql.Extensions;

namespace FirebirdSql.Metadata.Comparer.Lib.RDBModel
{
    public class FirebirdRdbContext : DbContext
    {
        /// <summary>
        /// Constructor for dependency injection
        /// </summary>
        /// <param name="options"></param>
        public FirebirdRdbContext(DbContextOptions<FirebirdRdbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RdbDatabase>().ToTable("Database");

            modelBuilder.Entity<RdbCollation>().HasKey(k => new { k.CollationId, k.CharacterSetId });
            modelBuilder.Entity<RdbDependency>().HasKey(k => new { k.DependentName, k.DependedOnName });
            modelBuilder.Entity<RdbFunctionArgument>().HasKey(k => new { k.FunctionName, k.ArgumentPosition });

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.Relational().TableName = "RDB$" + entity.Relational().TableName.ToSnakeCase().ToUpper();

                // Replace column names         
                foreach (var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = "RDB$" + property.Name.ToSnakeCase().ToUpper();
                }
            }
        }

        /// <summary>
        /// History of backups performed using nBackup
        /// </summary>
        public DbSet<RdbBackupHistory> BackupHistory { get; set; }

        /// <summary>
        /// Names and describes the character sets available in the database
        /// </summary>
        public DbSet<RdbCharacterSet> CharacterSets { get; set; }

        /// <summary>
        /// Cross references between the names of constraints(NOT NULL constraints, CHECK constraints and ON UPDATE and ON DELETE clauses in foreign key constraints) and their associated system-generated triggers
        /// </summary>
        public DbSet<RdbCheckConstraint> CheckConstraints { get; set; }

        /// <summary>
        /// Collation sequences for all character sets
        /// </summary>
        public DbSet<RdbCollation> Collations { get; set; }

        /// <summary>
        /// Basic information about the database
        /// </summary>
        public DbSet<RdbDatabase> RdbDatabase { get; set; }

        /// <summary>
        /// Information about dependencies between database objects
        /// </summary>
        public DbSet<RdbDependency> Dependencies { get; set; }

        /// <summary>
        /// Custom database exceptions
        /// </summary>
        public DbSet<RdbException> Exceptions { get; set; }

        /// <summary>
        /// Column and domain definitions, both system and custom
        /// </summary>
        public DbSet<RdbField> Fields { get; set; }

        /// <summary>
        /// Dimensions of array columns
        /// </summary>
        public DbSet<RdbFieldDimension> FieldDimensions { get; set; }

        /// <summary>
        /// Information about secondary files and shadow files
        /// </summary>
        public DbSet<RdbFile> Files { get; set; }

        /// <summary>
        /// Information about BLOB filters
        /// </summary>
        public DbSet<RdbFilter> Filters { get; set; }

        /// <summary>
        /// Information about changes in the formats of tables
        /// </summary>
        public DbSet<RdbFormat> Formats { get; set; }

        /// <summary>
        /// Information about external functions
        /// </summary>
        public DbSet<RdbFunction> Functions { get; set; }

        /// <summary>
        /// Attributes of the parameters of external functions
        /// </summary>
        public DbSet<RdbFunctionArgument> FunctionArguments { get; set; }

        /// <summary>
        /// Information about generators (sequences)
        /// </summary>
        //public DbSet<RdbGenerator> Generators { get; set; }

        /// <summary>
        /// Segments and index positions
        /// </summary>
        //public DbSet<RdbIndexSegment> IndexSegments { get; set; }

        /// <summary>
        /// Definitions of all indexes in the database (system- or user-defined)
        /// </summary>
        //public DbSet<RdbIndex> Indices { get; set; }

        /// <summary>
        /// Not used in the current version
        /// </summary>
        //public DbSet<RdbLogFile> LogFiles { get; set; }

        /// <summary>
        /// Information about database pages
        /// </summary>
        //public DbSet<RdbPage> Pages { get; set; }

        /// <summary>
        /// Parameters of stored procedures
        /// </summary>
        //public DbSet<RdbProcedureParameter> ProcedureParameters { get; set; }

        /// <summary>
        /// Definitions of stored procedures
        /// </summary>
        //public DbSet<RdbProcedure> Procedures { get; set; }

        /// <summary>
        /// Definitions of referential constraints (foreign keys)
        /// </summary>
        //public DbSet<RdbRefConstraint> RefConstraints { get; set; }

        /// <summary>
        /// Definitions of all table-level constraints
        /// </summary>
        //public DbSet<RdbRelationConstraint> RelationConstraints { get; set; }

        /// <summary>
        /// Top-level definitions of table columns
        /// </summary>
        //public DbSet<RdbRelationField> RelationFields { get; set; }

        /// <summary>
        /// Headers of tables and views
        /// </summary>
        //public DbSet<RdbRelation> Relations { get; set; }

        /// <summary>
        /// Role definitions
        /// </summary>
        //public DbSet<RdbRole> Roles { get; set; }

        /// <summary>
        /// Access control lists
        /// </summary>
        //public DbSet<RdbSecurityClass> SecurityClasses { get; set; }

        /// <summary>
        /// State of multi-database transactions
        /// </summary>
        //public DbSet<RdbTransaction> Transactions { get; set; }

        /// <summary>
        /// Trigger messages
        /// </summary>
        //public DbSet<RdbTriggerMessage> TriggerMessages { get; set; }

        /// <summary>
        /// Trigger definitions
        /// </summary>
        //public DbSet<RdbTrigger> Triggers { get; set; }

        /// <summary>
        /// Definitions of enumerated data types
        /// </summary>
        //public DbSet<RdbType> Types { get; set; }

        /// <summary>
        /// SQL privileges granted to system users
        /// </summary>
        //public DbSet<RdbUserPrivilege> UserPrivileges { get; set; }

        /// <summary>
        /// Tables that are referred to in view definitions: one record for each table in a view
        /// </summary>
        //public DbSet<RdbViewRelation> ViewRelations { get; set; }
    }
}
