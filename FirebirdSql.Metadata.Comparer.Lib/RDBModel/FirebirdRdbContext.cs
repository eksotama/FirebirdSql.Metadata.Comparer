using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
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

            //modelBuilder.Entity<CharacterSet>().ToTable("CharacterSets");

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
        /// RDB$BACKUP_HISTORY stores the history of backups performed using the nBackup utility.
        /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-backuphistory.html"/>
        /// </summary>
        public DbSet<BackupHistory> BackupHistory { get; set; }

        /// <summary>
        /// RDB$CHARACTER_SETS names and describes the character sets available in the database.
        /// <see href="https://firebirdsql.org/file/documentation/reference_manuals/fblangref25-en/html/fblangref-appx04-charactersets.html"/>
        /// </summary>
        public DbSet<CharacterSet> CharacterSets { get; set; }


    }
}
