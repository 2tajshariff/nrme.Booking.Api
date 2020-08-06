using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using nrme.Booking.Api;
using nrme.Booking.Api.Config;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using nrme.Booking.Api.DBContext;
using nrme.Booking.Api.Data;

namespace nrme.Booking.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Booking API", Version = "v1" });
            });
            services.AddDbContext<DBContext.NRMEDBContext>
                (opt => opt.UseSqlServer(Configuration["Data:CommandAPIConnection:ConnectionString"]));

            services.AddScoped<BookingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var swaggerConfig = new SwaggerConfig();
            Configuration.GetSection(nameof(SwaggerConfig)).Bind(swaggerConfig);

            app.UseSwagger(config => { config.RouteTemplate = swaggerConfig.JsonRoute; });

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint(swaggerConfig.UIEndpoint, swaggerConfig.Desciption);
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
