using System;
using System.Linq;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using ChannelEngine.Common;
using ChannelEngineModels;
using ChannelEngineService.Gateway;
using ChannelEngineService.Interfaces;
using ChannelEngineService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChannelEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);
            var containerBuilder = new ContainerBuilder();
            ConfigureContainer(containerBuilder);
            var container = containerBuilder.Build();

            using (var scope = container.BeginLifetimeScope("MyIsolatedRoot", b =>
                   {
                       b.Populate(services, "MyIsolatedRoot");
                   }))
            {
                // This service provider will have access to global singletons
                // and registrations but the "singletons" for things registered
                // in the service collection will be "rooted" under this
                // child scope, unavailable to the rest of the application.
                //
                // Obviously it's not super helpful being in this using block,
                // so likely you'll create the scope at app startup, keep it
                // around during the app lifetime, and dispose of it manually
                // yourself during app shutdown.
                var serviceProvider = new AutofacServiceProvider(scope);
                var orderService = scope.Resolve<IOrderService>();
                var productService = scope.Resolve<IProductService>();

                var orders = orderService.GetOrders("IN_PROGRESS");
                var products = productService.GetProductDetails(orders.Result.Content.First().Lines, 5);
                productService.UpdateProductStock(new UpdateProductRequest()
                {
                    MerchantProductNo = products.Result.First().MerchantProductNo,
                    StockLocations = new StockLocation[1]
                    {
                        new StockLocation()
                        {
                            StockLocationId = 1,
                            Stock = 25
                        }
                    }
                });
            }

            

            Console.WriteLine("Hello World!");
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient(); //Register HTTP Client
        }

        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingInterceptor>();
            builder.RegisterType<OrderService>().As<IOrderService>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
            builder.RegisterType<ProductService>().As<IProductService>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
            builder.RegisterType<ChannelEngineClient>().As<IChannelEngineClient>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
        }
    }
}
