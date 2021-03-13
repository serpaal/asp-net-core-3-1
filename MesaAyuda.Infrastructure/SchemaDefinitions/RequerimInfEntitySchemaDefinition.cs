using MesaAyuda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MesaAyuda.Infrastructure.SchemaDefinitions
{
    class RequerimInfEntitySchemaDefinition : IEntityTypeConfiguration<RequerimInf>
    {
        public void Configure(EntityTypeBuilder<RequerimInf> builder)
        {
                builder.HasNoKey();

                builder.ToTable("REQUERIM_INF");

                builder.Property(e => e.ArchAdj)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("arch_adj");

                builder.Property(e => e.CodArea)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("cod_area");

                builder.Property(e => e.CodURbl)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod_u_rbl")
                    .IsFixedLength(true);

                builder.Property(e => e.CodURcp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod_u_rcp")
                    .IsFixedLength(true);

                builder.Property(e => e.CodUsr)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod_usr")
                    .IsFixedLength(true);

                builder.Property(e => e.CodVinc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cod_vinc")
                    .IsFixedLength(true);

                builder.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength(true);

                builder.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_cierre");

                builder.Property(e => e.FechaSol)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_sol");

                builder.Property(e => e.NroReq)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nro_req");

                builder.Property(e => e.Observ)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observ");

                builder.Property(e => e.Proyecto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("proyecto");          
        }
    }
}
