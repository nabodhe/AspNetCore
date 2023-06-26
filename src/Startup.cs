using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ASPNet_Test
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logging)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseFileServer();

            //app.Run((context) =>
            //{
            //    throw new Exception("Custom Exception");
            //});

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

                 app.Run(async (context) => {
                await context.Response.WriteAsync(
                    System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToString()
                    + Environment.NewLine + Configuration["MyKey"]
                    );

            });*/

            /*app.Use(async (context, next) =>
                {
                    logging.LogInformation("MW1 : Incoming Request");
                    await next();
                    logging.LogInformation("MW1 : Outgoing Request");
                });
            */


            /*app.Use(async (context, next) =>
            {
                logging.LogInformation("MW2 : Incoming Request");
                await next();
                logging.LogInformation("MW2 : Outgoing Request");
            });
            */
            app.Run(async (context) => {
                                            await context.Response.WriteAsync("MW3 : Request handled and response produced" + env.EnvironmentName);
                                            logging.LogInformation("MW3 : Request handled and response produced");
                                        });

            
}
}
}
