using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.DataAccess;
using eManager.DataAccess.Repositories;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NToastNotify;


namespace eManager
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<CloudBlobClient>(sp => { return CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=ognootpornostorage;AccountKey=hHJZOCStm4b3XRgaNa2+1386NvNkc4I+F3BzZruYRqgpHV5zyVcm3pKJ2THkHCHf4b6imFI7S2ztVgXLuQmqvw==;EndpointSuffix=core.windows.net").CreateCloudBlobClient(); });
            services.ConfigureApplicationCookie(opt =>
            {
                opt.AccessDeniedPath = new PathString("/Roles/Denied");
            });
            var appConfig = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appConfig);


            //Using AppSettings section
            var appSettings = appConfig.Get<AppSettings>();
            DiModule.RegisterModule(services, appSettings.eManagerDbConnectionString);

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/User/LogIn";
                options.AccessDeniedPath = "/User/LogIn";
                options.SlidingExpiration = true;
            });
            services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
            {
                ProgressBar = false,
                PositionClass = ToastPositions.TopRight
            });



          

            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProcurementService, ProcurementService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IUserService, UserService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseNToastNotify();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
