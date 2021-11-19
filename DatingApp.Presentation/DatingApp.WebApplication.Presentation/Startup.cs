using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
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

namespace DatingApp.WebApplication.Presentation
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
            services.AddAuthentication();
            services.AddAuthorization();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<IUnitOfWork, NewUnitOfWork>();
            services.AddScoped<IChatRepository, ChatRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<ILookupTypeRepository, LookupTypeRepository>();
            services.AddScoped<ILookupValueRepository, LookupValueRepository>();
            services.AddScoped<ILookupValueService, LookupValueService>();
            services.AddScoped<ILookupTypeService, LookupTypeService>();
            services.AddScoped<DatingAppWinFormsContext, DatingAppWinFormsContext>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Registration/Index");
            });
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

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default2",
                   pattern: "{controller=Registration}/{action=Index}/{id}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Registration}/{action=Index}/{id?}");
                
            });
        }
    }
}
