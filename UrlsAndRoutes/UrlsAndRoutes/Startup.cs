using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace UrlsAndRoutes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "MyRoute1",
                    template: "{controller:regex(^H.*)=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "MyRoute2",
                    template: "{controller=Home}/{action=Index}/{id:int?}");

                routes.MapRoute(
                    name: "MyRoute3",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" },
                    constraints: new { id = new IntRouteConstraint() });

                routes.MapRoute(
                    name: "MyRoute4",
                    template: "{controller:regex(^H.*)=Home}/" + "{action:regex(^Index$|^About$)=Index}/{id?}");
            });
        }
    }
}
