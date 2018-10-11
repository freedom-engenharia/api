﻿// <auto-generated />
using System;
using AutomacaoFreedom.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutomacaoFreedomApi.Migrations
{
    [DbContext(typeof(AutomacaoFreedomContexto))]
    partial class AutomacaoFreedomContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataModificacao");

                    b.Property<string>("Logo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Empresa","Tipologia");
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.Local", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataModificacao");

                    b.Property<string>("Logo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("UnidadeId");

                    b.HasKey("Id");

                    b.HasIndex("UnidadeId");

                    b.ToTable("Local","Tipologia");
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.SubLocal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataModificacao");

                    b.Property<Guid?>("LocalId")
                        .IsRequired();

                    b.Property<string>("Logo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.ToTable("SubLocal","Tipologia");
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.Unidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataModificacao");

                    b.Property<Guid>("EmpresaId");

                    b.Property<string>("Logo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Unidade","Tipologia");
                });

            modelBuilder.Entity("AutomacaoFreedomApi.Entidade.Hardware.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataModificacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status");

                    b.Property<Guid>("SubLocalId");

                    b.HasKey("Id");

                    b.HasIndex("SubLocalId");

                    b.ToTable("Device","Hardware");
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.Local", b =>
                {
                    b.HasOne("AutomacaoFreedom.Entidade.Tipologia.Unidade", "Unidade")
                        .WithMany("Locais")
                        .HasForeignKey("UnidadeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.SubLocal", b =>
                {
                    b.HasOne("AutomacaoFreedom.Entidade.Tipologia.Local", "Local")
                        .WithMany("SubLocais")
                        .HasForeignKey("LocalId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomacaoFreedom.Entidade.Tipologia.Unidade", b =>
                {
                    b.HasOne("AutomacaoFreedom.Entidade.Tipologia.Empresa", "Empresa")
                        .WithMany("Unidades")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("AutomacaoFreedomApi.Entidade.Hardware.Device", b =>
                {
                    b.HasOne("AutomacaoFreedom.Entidade.Tipologia.SubLocal", "SubLocal")
                        .WithMany("Devices")
                        .HasForeignKey("SubLocalId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
