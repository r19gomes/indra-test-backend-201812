using AspNetMvc.Api.Applications.Contract.Banco;
using AspNetMvc.Api.Applications.Contract.ContaCorrente;
using AspNetMvc.Api.Applications.Implementation.Banco;
using AspNetMvc.Api.Applications.Implementation.ContaCorrente;
using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Services;
using AspNetMvc.Api.Infrastructures.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace AspNetMvc.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddControllersAsServices()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Teste Prático Indra",
                    Version = "v1",
                    Description = "TESTE PRÁTICO INDRA para o Banco Santander de API REST criada com o ASP.NET Core",
                    Contact = new Contact
                    {
                        Name = "Roberto Gomes da Silva",
                        Email = "r19gomes@gmail.com",
                        Url = "https://github.com/r19gomes"
                    }
                });
            });

            services.AddScoped<IBancoRepositories, BancoRepositories>();
            services.AddScoped<IBancoServices, BancoServices>();
            services.AddScoped<IBancoAppService, BancoAppService>();

            services.AddScoped<IContaCorrenteRepositories, ContaCorrenteRepositories>();
            services.AddScoped<IContaCorrenteServices, ContaCorrenteServices>();
            services.AddScoped<IContaCorrenteAppService, ContaCorrenteAppService>();

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

            app.UseHttpsRedirection();
            app.UseMvc();

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "TESTE PRÁTICO INDRA API V1");
            });
        }

    }
}
