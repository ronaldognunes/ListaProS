using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaProp.Domain.Interfaces;
using ListaProp.Infra.Contexto;
using ListaProp.Infra.Repositorio;
using ListaProp.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ListaProp.api
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
            services.AddDbContext<SqLiteContext>(
                opt => opt.UseSqlite(Configuration["ConexaoSqlite:SqliteConnectionString"])                
            );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //repositorios
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<IUsuarioRepository,UsuarioRepository>();
            services.AddScoped<IItemRepository,ItemRepository>();
            services.AddScoped<IListaRepository,ListaRepository>();

            //Serviços 
            services.AddScoped<IUsuarioService,UsuarioService>();
            services.AddScoped<IListaService,ListaService>();
            services.AddScoped<IItemService,ItemService>();


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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
