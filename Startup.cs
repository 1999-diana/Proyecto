using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proyecto.Data;

namespace Proyecto
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
            services.AddControllersWithViews();
            //Connecion de la base de datos
            string BaseDatos = Configuration.GetSection("Parametros").GetSection("BaseDatos").Value;
            if (BaseDatos == "SqlServer")
            {
                string conn = Configuration.GetConnectionString("ConnDbServer");
                services.AddDbContext<DBLiquidacion>(options => options.UseSqlServer(conn));
            }
            if(BaseDatos=="Postgres")
            {
                string connPostgres = Configuration.GetConnectionString("ConnDbPostgres");
                services.AddDbContext<DBLiquidacion>(options => options.UseNpgsql(connPostgres));
            }
            if(BaseDatos == "Memory")
            {
                services.AddDbContext<DBLiquidacion>(options => options.UseInMemoryDatabase(databaseName:"DBMemory"));
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
