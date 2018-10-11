
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Infraestrutura.EntidadesConfiguracao;
using AutomacaoFreedomApi.Entidade.Hardware;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutomacaoFreedom.Repositorios
{
    public class AutomacaoFreedomContexto : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string de conexão banco local
            optionsBuilder.UseSqlServer("Server=DESKTOP-680NKVQ;Database=AutomacaoFreedom;Trusted_Connection=true;");
        }

        public AutomacaoFreedomContexto(DbContextOptions<AutomacaoFreedomContexto> options)
           : base(options)
        {
           Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //Configuração das entidades no banco de dados
            TipologiaEntidadeConfiguracao.InitializeMapping(modelBuilder);
            HardwareEntidadeConfiguracao.InitializeMapping(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        //Tipologia
        public DbSet<SubLocal> SubLocal { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Empresa> Empresa { get; set; }

        //Hardware
        public DbSet<Device> Device { get; set; }
    }
}