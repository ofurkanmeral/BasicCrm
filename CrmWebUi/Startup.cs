using CrmData.Abstract;
using CrmData.Concrete;
using CrmWebUi.EmailService;
using CrmWebUi.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                            .AddRazorRuntimeCompilation();

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<INotifyRepository, notifyRepository>();
            
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-39583MR\SQLEXPRESS;Initial Catalog=CrmData;Integrated Security=SSP9I;MultipleActiveResultSets=true"));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.AddScoped<ICalisan, CalisanRepository>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireNonAlphanumeric = false;

                options.Lockout.MaxFailedAccessAttempts = 5;//5 kere yanlýþ girme hakký var sonra kilitlenir
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//buda kilitlendikten sonra ne zaman kilidi açacaðýmýz telefondaki 30 saniyelik 5 kere yanlýþ girdikten sonraki mantýk
                options.Lockout.AllowedForNewUsers = true; //yukardaki özelliklerin kulllanýlmasý için

                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";//admin sayflarýna eriþmesinler diye
                options.SlidingExpiration = true;//cookie zamaný olsun
                options.ExpireTimeSpan = TimeSpan.FromMinutes(6000);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".Fom.Cookie",
                    SameSite = SameSiteMode.Strict //sadece cokie deðil cokienin konumuda önemli firstsafety
                };
            });


            services.AddScoped<IEmailService, SendMail>(i =>
                 new SendMail(
                     _configuration["EmailSender:Host"],
                     _configuration.GetValue<int>("EmailSender:Port"),
                     _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                     _configuration.GetValue<string>("EmailSender:userName"),
                     _configuration["EmailSender:password"]

                     )
                );

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"denemeler",
                    pattern:"/company/{companyname}",
                    defaults: new {controller="company",action="detail"}
                    );
                endpoints.MapControllerRoute(
                   name: "Detay",
                   pattern: "detay/{id?}",
                   defaults: new { controller = "company", action = "detail" }
                   );

                endpoints.MapControllerRoute(
                    name:"kategorilistesi",
                    pattern:"/list/{category?}",
                    defaults:new { controller="company",action= "ListCategory" }
                    );

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=vericekme}/{action=index4}/{id?}"
                    );

                endpoints.MapControllerRoute(
                   name: "anasayfakategorylistesi",
                   pattern: "/Category/{category?}",
                   defaults: new { controller = "company", action = "Anasayfa" }
                   );

            });
        }
    }
}
