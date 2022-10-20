using Autofac;
using Autofac.Extras.DynamicProxy;
using ChannelEngine.Common;
using ChannelEngine.Web.Middlewares;
using ChannelEngineService.Gateway;
using ChannelEngineService.Interfaces;
using ChannelEngineService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineWeb
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
            services.AddHttpClient(); //Register HTTP Client
            services.AddControllersWithViews();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingInterceptor>();
            builder.RegisterType<OrderService>().As<IOrderService>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
            builder.RegisterType<ProductService>().As<IProductService>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
            builder.RegisterType<ChannelEngineClient>().As<IChannelEngineClient>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseAppException();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Order}/{action=Index}");
            });
        }
    }
}
