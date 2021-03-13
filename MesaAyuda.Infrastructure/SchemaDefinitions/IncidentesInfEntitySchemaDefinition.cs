using MesaAyuda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MesaAyuda.Infrastructure.SchemaDefinitions
{
    class IncidentesInfEntitySchemaDefinition : IEntityTypeConfiguration<IncidentesInf>
    {
        public void Configure(EntityTypeBuilder<IncidentesInf> entity)
        {
            entity.HasNoKey();

            entity.ToTable("INCIDENTES_INF");

            entity.Property(e => e.ArchAdj)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("arch_adj");

            entity.Property(e => e.CodArea)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("cod_area");

            entity.Property(e => e.CodURbl)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("cod_u_rbl")
                .IsFixedLength(true);

            entity.Property(e => e.CodURcp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("cod_u_rcp")
                .IsFixedLength(true);

            entity.Property(e => e.CodUsr)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("cod_usr")
                .IsFixedLength(true);

            entity.Property(e => e.CodVinc)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("cod_vinc")
                .IsFixedLength(true);

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estado")
                .IsFixedLength(true);

            entity.Property(e => e.FechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cierre");

            entity.Property(e => e.FechaSol)
                .HasColumnType("datetime")
                .HasColumnName("fecha_sol");

            entity.Property(e => e.NroInc)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nro_inc");

            entity.Property(e => e.Observ)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observ");        
        }
    }
}
