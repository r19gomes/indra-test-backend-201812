using AspNetMvc.Api.Applications.Implementation.ContaCorrente;
using AspNetMvc.Api.Applications.Contract.ContaCorrente;
using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Services;
using AspNetMvc.Api.Infrastructures.DataAccess.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services
        //        .AddMvc()
        //        .AddControllersAsServices()
        //        .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        //    //services.AddSingleton<IContaCorrenteAppService, ContaCorrenteAppService>();
        //    //services.AddScoped<IContaCorrenteAppService, ContaCorrenteAppService>();
        //    //services.AddTransient<IContaCorrenteAppService, ContaCorrenteAppService>();
        //    //services.AddSingleton<IContaCorrenteAppService>(x => x.GetRequiredService<ContaCorrenteAppService>());

        //    //services.RegisterAllTypes<IContaCorrenteAppService>(new[] { typeof(Startup).Assembly });

        //    services.AddTransient<IContaCorrenteAppService, ContaCorrenteAppService>();
        //    //services.AddHttpClient<IContaCorrenteAppService, ContaCorrenteAppService>();

        //    // Create an Autofac Container and push the framework services
        //    //var containerBuilder = new ContainerBuilder();
        //    //containerBuilder.Populate(services);

        //    //// Register your own services within Autofac
        //    //containerBuilder.RegisterType<IContaCorrenteAppService>().As<IContaCorrenteAppService>();

        //    //// Build the container and return an IServiceProvider from Autofac
        //    //var container = containerBuilder.Build();
        //    //return container.Resolve<IServiceProvider>();
        //}

        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();

        //    // Create the container builder.
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<ContaCorrenteAppService>().As<IContaCorrenteAppService>();
        //    builder.Populate(services);
        //    var container = builder.Build();

        //    // Create the IServiceProvider based on the container.
        //    return new AutofacServiceProvider(container);
        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddControllersAsServices()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

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
        }
    }
}
