using MesaAyuda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MesaAyuda.Infrastructure.SchemaDefinitions
{
    class RequerimientoInfoEntitySchemaDefinition : IEntityTypeConfiguration<RequerimientoInfo>
    {
        public void Configure(EntityTypeBuilder<RequerimientoInfo> builder)
        {
            builder.ToTable("requerimiento_info", MesaAyudaContext.DEFAULT_SCHEMA);

            builder.HasKey(k => k.NroReq);

            builder.Property(e => e.NroReq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nro_req");

            builder.Property(e => e.Asignado)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("asignado");

            builder.Property(e => e.CodOtr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cod_otr");

            builder.Property(e => e.CodUDrv)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cod_u_drv");

            builder.Property(e => e.CodURbl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cod_u_rbl");

            builder.Property(e => e.DescripReq)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descrip_req");

            builder.Property(e => e.Detalle)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.EstDetalle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("est_detalle");

            builder.Property(e => e.EstReq)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("est_req");

            builder.Property(e => e.FechaEje)
                .HasColumnType("date")
                .HasColumnName("fecha_eje");

            builder.Property(e => e.FechaIniTi)
                .HasColumnType("date")
                .HasColumnName("fecha_ini_ti");

            builder.Property(e => e.FechaSol)
                .HasColumnType("date")
                .HasColumnName("fecha_sol");

            builder.Property(e => e.Solicitante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("solicitante");
        }
    }
}
