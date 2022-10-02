using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffAttendanceApps.Models;

namespace StaffAttendanceApps
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

            services.AddDbContext<StaffDBContext>(opts =>
           opts.UseSqlServer(Configuration.GetConnectionString("Sstaff")));
            services.AddScoped<IStaffRepository, StaffRepository>();

            var authenticationBuilder = services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Authentication";
                options.DefaultSignInScheme = "Authentication";


            });

            //add main cookie authentication
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "Authentication";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromSeconds(60000);
                options.LoginPath = "/Login/Login";

            });

            //services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddAuthentication().AddCookie("Authentication");
            services.AddAuthentication("Authentication")
            .AddCookie(o =>
            {
                o.Cookie.Name = "Authentication";
                o.Cookie.Domain = "Authentication";
                o.SlidingExpiration = false;

            });


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(5);
                options.LoginPath = "/Login/Login";
                options.AccessDeniedPath = "/Login/LogOut";
            });


            services.AddMvc();
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30); });
            // MvcOptions.
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}

