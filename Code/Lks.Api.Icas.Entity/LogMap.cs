// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// Log
    /// </summary>
    public class LogMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Log>
    {
        public LogMap()
            : this("dbo")
        {
        }

        public LogMap(string schema)
        {
            ToTable("Log", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsRequired();
            Property(x => x.Thread).HasColumnName(@"Thread").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Level).HasColumnName(@"Level").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Logger).HasColumnName(@"Logger").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Message).HasColumnName(@"Message").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Exception).HasColumnName(@"Exception").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
// </auto-generated>