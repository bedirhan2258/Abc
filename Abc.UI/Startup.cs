using Abc.Business.Abstract;
using Abc.Business.Concreate;
using Abc.DataAccess.Concreate.EntityFramework;
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
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Default olarak home controller index sayfasına git demek.

            app.UseMvcWithDefaultRoute();
        }
    }
}
