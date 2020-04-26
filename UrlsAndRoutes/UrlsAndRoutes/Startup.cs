using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Routing;
using UrlsAndRoutes.Infrastructure;
namespace UrlsAndRoutes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("weekday", typeof(WeekDayConstraint)));
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "NewRoute",
                //    template: "App/Do{action}",
                //    defaults: new { controller = "Home" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "out",
                    template: "outbound/{controller=Home}/{action=Index}");
            });
        }
    }
}
