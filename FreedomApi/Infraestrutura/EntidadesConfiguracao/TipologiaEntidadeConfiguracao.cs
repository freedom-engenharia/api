
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Entidades.Tipologia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomacaoFreedom.Infraestrutura.EntidadesConfiguracao
{
    public class TipologiaEntidadeConfiguracao
    {

        public static void InitializeMapping(ModelBuilder modelBuilder)
        {
            SubLocalMapping(modelBuilder.Entity<SubLocal>());
            LocalMapping(modelBuilder.Entity<Local>());
            UnidadeMapping(modelBuilder.Entity<Unidade>());
            EmpresaMapping(modelBuilder.Entity<Empresa>());
        }

        private static void SubLocalMapping(EntityTypeBuilder<SubLocal> entity)
        {

            entity.ToTable("SubLocal", schema: "Tipologia");

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
            
            entity.HasOne(d => d.Local)
                .WithMany(p => p.SubLocais)
                .IsRequired()
                .HasForeignKey(d => d.LocalId)
                .OnDelete(DeleteBehavior.Restrict);


        }

        private static void LocalMapping(EntityTypeBuilder<Local> entity)
        {

            entity.ToTable("Local", schema: "Tipologia");

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

            entity.HasOne(d => d.Unidade)
                .WithMany(p => p.Locais)
                .IsRequired()
                .HasForeignKey(d => d.UnidadeId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void UnidadeMapping(EntityTypeBuilder<Unidade> entity)
        {

            entity.ToTable("Unidade", schema: "Tipologia");

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

            entity.HasOne(d => d.Empresa)
                .WithMany(p => p.Unidades)
                .IsRequired()
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void EmpresaMapping(EntityTypeBuilder<Empresa> entity)
        {

            entity.ToTable("Empresa", schema: "Tipologia");

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
        }
    }
}

