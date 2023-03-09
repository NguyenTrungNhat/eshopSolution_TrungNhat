using eShopSolution.Application.Catalog.Products;
using eShopSolution.Application.Common;
using eShopSolution.Data.EF;
using eShopSolution.Utilities.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace eshopSolution.BackendAPI
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
            services.AddDbContext<EShopDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

            //Declare DI
            services.AddTransient<IStorageService,FileStorageService>();

            services.AddTransient<IPublicProductService, PublicProductService>();
            services.AddTransient<IManageProductService, ManageProductService>();


            services.AddControllers();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Swagger eShop Solution", Version="v1" });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger eShopSolution V1");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
