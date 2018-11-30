// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// TeaReqMathing
    /// </summary>
    public class TeaReqMathingMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TeaReqMathing>
    {
        public TeaReqMathingMap()
            : this("dbo")
        {
        }

        public TeaReqMathingMap(string schema)
        {
            ToTable("TeaReqMathing", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TeaReqId).HasColumnName(@"TeaReqId").HasColumnType("int").IsRequired();
            Property(x => x.MathingId).HasColumnName(@"MathingId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Matching).WithMany(b => b.TeaReqMathings).HasForeignKey(c => c.MathingId); // FK_TeaReqMathing_Matching
            HasRequired(a => a.TeaReq).WithMany(b => b.TeaReqMathings).HasForeignKey(c => c.TeaReqId); // FK_TeaReqMathing_TeaReq
        }
    }

}
// </auto-generated>