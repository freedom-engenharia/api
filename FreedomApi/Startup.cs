
using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Aplicacao.Concreta;
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Infraestrutura;
using AutomacaoFreedomApi.Repositorio;
using AutomacaoFreedomApi.Repositorio.Hardware.Concreta;
using AutomacaoFreedomApi.Repositorio.Tipologia.Concreta;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using AutomacaoFreedomApi.Repositorios;
using AutomacaoFreedomApi.Repositorios.Hardware.Interface;
using AutomacaoFreedomApi.Repositorios.Tipologia.Concreta;
using AutomacaoFreedomApi.Servico.Hardware.Concreta;
using AutomacaoFreedomApi.Servico.Hardware.Interface;
using AutomacaoFreedomApi.Servico.Tipologia.Concreta;
using AutomacaoFreedomApi.Servico.Tipologia.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutomacaoFreedomApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMqttServico>(factory => {
                return new MqttServico("");
            });

            //Tipologia
            services.AddScoped<ITipologiaAplicacao, TipologiaAplicacao>();

            services.AddScoped<ISubLocalRepositorio, SubLocalRepositorio>();
            services.AddScoped<ISubLocalServico, SubLocalServico>();

            services.AddScoped<ILocalRepositorio, LocalRepositorio>();
            services.AddScoped<ILocalServico, LocalServico>();


            services.AddScoped<IUnidadeRepositorio, UnidadeRepositorio>();
            services.AddScoped<IUnidadeServico, UnidadeServico>();

            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            services.AddScoped<IEmpresaServico, EmpresaServico>();

            //Hardware
            services.AddScoped<IHardwareAplicacao, HardwareAplicacao>();

            services.AddScoped<IDeviceRepositorio, DeviceRepositorio>();
            services.AddScoped<IDeviceServico, DeviceServico>();

            //services.AddScoped<IMqttServico, MqttServico>();

            //UnitOfWork
            services.AddScoped<IAutomacaoFreedomUnitOfWork, AutomacaoFreedomUnitOfWork>();

            //Context
            services.AddDbContext<AutomacaoFreedomContexto>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Mapeador automaticco
            MapeadorAutomaticoConteiner.Initialize();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRequestLocalization(new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture("pt-BR"),
                RequestCultureProviders = null
            });

            app.UseHttpsRedirection();
            app.UseMvc();

           
        }
    }
}
