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

            //builder.Services.AddTransient(); Istedi�iniz kadar newliyor her tablepte new i�lemini tekrar yapar.
            //builder.Services.AddSingleton(); sadece 1 kere kullan�l�yor talep edildi�inde bunu tekrar kullan�yor.
            //builder.Services.AddScoped();    sadece 1 kere ge�erli oluyor sonra scope bitince �l�yor.

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddFluentValidationClientsideAdapters();


            builder.Services.AddSingleton<IAdminBs, AdminBs>();
            builder.Services.AddSingleton<IAdminRepository, EfAdminRepository>();

            //Session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
                //5 dakika hi� bir i�lem yapmadan beklersen seni sistem otomatik olarak d��ar� atar session s�f�rlan�r veya ba�ka bir de�i�le null olur.
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