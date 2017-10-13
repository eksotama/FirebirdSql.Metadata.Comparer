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
        public FirebirdRdbContext(DbContextOptions<FirebirdRdbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

        public DbSet<BackupHistory> BackupHistory { get; set; }

        public DbSet<CharacterSets> CharacterSets { get; set; }
    }
}
