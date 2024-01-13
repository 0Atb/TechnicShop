using FluentValidation;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Bussiness.Concrete;
using TechnicShop.Bussiness.Validasyon.Areas.Admin;
using TechnicShop.DataAccess.Abstract;
using TechnicShop.DataAccess.Concrete.Repository;
using TechnicShop.Model.ViewModels.Areas.Admin;
using TechnicShop.MVCUI.Areas.Admin.Filters;

namespace TechnicShop.MVCUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddNewtonsoftJson(options=>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            //builder.Services.AddTransient(); Istediðiniz kadar newliyor her tablepte new iþlemini tekrar yapar.
            //builder.Services.AddSingleton(); sadece 1 kere kullanýlýyor talep edildiðinde bunu tekrar kullanýyor.
            //builder.Services.AddScoped();    sadece 1 kere geçerli oluyor sonra scope bitince ölüyor.

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddFluentValidationClientsideAdapters();


            builder.Services.AddSingleton<IAdminBs, AdminBs>();
            builder.Services.AddSingleton<IAdminRepository, EfAdminRepository>();

            //Session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                //5 dakika hiç bir iþlem yapmadan beklersen seni sistem otomatik olarak dýþarý atar session sýfýrlanýr veya baþka bir deðiþle null olur.
            });
            builder.Services.AddSingleton<ISessionManager, SessionManager>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //Validasyon
            builder.Services.AddSingleton<IValidator<LogInViewModel>, LogInVmValidator>();
           



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run();
        }
    }
}