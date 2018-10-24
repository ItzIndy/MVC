using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HelloMVC {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddSession();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => { routes.MapRoute("default", "{controller=snake}/{action=index}/{id?}"); });
            //app.usemvcwithdefaultroute() is identiek als hierboven. 
            //app.run(async (context) => {
            //    await context.response.writeasync("hello world!");
            //});
        }
    }
}
