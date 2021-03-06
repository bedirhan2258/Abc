﻿using Abc.Business.Abstract;
using Abc.Business.Concreate;
using Abc.DataAccess.Abstract;
using Abc.DataAccess.Concreate.EntityFramework;
using Abc.UI.Middleware;
using AbcNorthwind.DataAccess.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Abc.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSession();
            //Bunu eklemeksek session aktifleştirilmemiş hatası alırız.
            services.AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //package.json dosyasının wwwwroot içinde gözükmesi için yazıldı.
            app.UseFileServer();

            //extension method tanımlayıp yolunu verdik.
            app.UseNodeModules(env.ContentRootPath);

            //Default olarak home controller index sayfasına git demek.

            app.UseMvcWithDefaultRoute();
            app.UseSession();
        }
    }
}
