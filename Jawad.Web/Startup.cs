using Jawad.Data;
using Jawad.Service.Beers.Services;
using Jawad.Service.Beers.Services.Interfaces;
using Jawad.Service.Brewers.Services;
using Jawad.Service.Brewers.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jawad.Web
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
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(
                    options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            var connection = @"Server=(localdb)\mssqllocaldb;Database=BeersDatabase;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<BeersContext>(options => options.UseSqlServer(connection));
            
            // Services
            services.AddScoped<IBrewerService, BrewerService>();
            services.AddScoped<IBeerService, BeerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
