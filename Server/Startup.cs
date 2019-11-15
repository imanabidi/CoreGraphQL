using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Orders.Schema;
using Orders.Services;
using GraphQL;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.WebSockets;

namespace Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IOrderServices, OrderServices>();
            services.AddSingleton<ICustomerServices, CustomerServices>();
            
            services.AddSingleton<OrderGraphType>();
            services.AddSingleton<CustomerType>();
            services.AddSingleton<OrderStatusesEnum>();

            services.AddSingleton<OrdersQuery>();
            services.AddSingleton<OrdersSchema>();
            

            services.AddSingleton<IDependencyResolver>(
                c=>new FuncDependencyResolver(type=> c.GetRequiredService(type))
                );
            services.AddGraphQLHttp();
            //services.AddGraphQLWebSocket<OrdersSchema>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseWebSockets();

            app.UseGraphQLHttp<OrdersSchema>(new GraphQLHttpOptions());
            //app.UseGraphQLWebSocket<OrdersSchema>(new GraphQLWebSocketsOptions());
        }
    }
}
