using MesaAyuda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MesaAyuda.Infrastructure.SchemaDefinitions
{
    class ReqQdetalleEntitySchemaDefinition : IEntityTypeConfiguration<ReqQdetalle>
    {
        public void Configure(EntityTypeBuilder<ReqQdetalle> entity)
        {
                entity.HasNoKey();

                entity.ToTable("REQ_QDETALLE");

                entity.Property(e => e.CodOtr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_otr");

                entity.Property(e => e.CodUDrv)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod_u_drv")
                    .IsFixedLength(true);

                entity.Property(e => e.CodURbl)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("cod_u_rbl")
                    .IsFixedLength(true);

                entity.Property(e => e.DescripReq)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descrip_req");

                entity.Property(e => e.DiasPru).HasColumnName("dias_pru");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength(true);

                entity.Property(e => e.Excep)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("excep")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaEje)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_eje");

                entity.Property(e => e.FechaEst)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_est");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ini");

                entity.Property(e => e.FechaIniTi)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ini_ti");

                entity.Property(e => e.FechaProEje)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_pro_eje");

                entity.Property(e => e.FechaSys)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_sys");

                entity.Property(e => e.JustifEje)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("justif_eje");

                entity.Property(e => e.Justific)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("justific");

                entity.Property(e => e.MotivoExc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("motivo_exc");

                entity.Property(e => e.NroReq)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nro_req");

                entity.Property(e => e.Observ)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("observ");

                entity.Property(e => e.Perfil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("perfil");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("prioridad")
                    .IsFixedLength(true);

                entity.Property(e => e.TiempoEje)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tiempo_eje");

                entity.Property(e => e.TiempoEst)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tiempo_est");
        }
    }
}
