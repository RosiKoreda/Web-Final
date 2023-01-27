using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using Microsoft.AspNetCore.Identity;

namespace SportsStore {
    public class Startup {

        public Startup(IConfiguration config) {
            Configuration = config;
        }

        private IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
                      services.AddDbContext<HaberDbContext>(opts => {
                opts.UseSqlServer(
                    Configuration["ConnectionStrings:HaberConnection"]);
            });
            services.AddScoped<IHaberRepository, EFHaberRepository>();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();          
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddServerSideBlazor();
            
            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(
                    Configuration["ConnectionStrings:IdentityConnection"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            if (env.IsProduction()) {
                app.UseExceptionHandler("/error");
            } else {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute("catpage",
                    "{category}/Page{haberPage:int}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("page", "Page{haberPage:int}",
                    new { Controller = "Home", action = "Index", haberPage = 1 });

                endpoints.MapControllerRoute("category", "{category}",
                    new { Controller = "Home", action = "Index", haberPage = 1 });

                endpoints.MapControllerRoute("pagination",
                    "Habers/Page{haberPage}",
                    new { Controller = "Home", action = "Index", haberPage = 1 });
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });

            
            IdentitySeedData.EnsurePopulated(app);
            HaberSeedData.EnsurePopulated(app);
        }
    }
}
