using AutomacaoFreedomApi.Entidade.Hardware;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomacaoFreedom.Infraestrutura.EntidadesConfiguracao
{
    public class HardwareEntidadeConfiguracao
    {

        public static void InitializeMapping(ModelBuilder modelBuilder)
        {
            DeviceMapping(modelBuilder.Entity<Device>());
        }

        private static void DeviceMapping(EntityTypeBuilder<Device> entity)
        {

            entity.ToTable("Device", schema: "Hardware");

            entity.HasKey(x => x.Id);

            entity.Property(p => p.Codigo)
                .HasColumnName("Codigo")
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("nvarchar(20)");

            entity.Property(p => p.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("nvarchar(200)");

            entity.HasOne(d => d.SubLocal)
                .WithMany(p => p.Devices)
                .IsRequired()
                .HasForeignKey(d => d.SubLocalId)
                .OnDelete(DeleteBehavior.Restrict);


        }
        
    }
}

