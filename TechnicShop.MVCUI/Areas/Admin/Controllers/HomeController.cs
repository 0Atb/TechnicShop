using Microsoft.AspNetCore.Mvc;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Model.Static;
using TechnicShop.Model.ViewModels.Areas.Admin;
using TechnicShop.Model.ViewModels.Areas.Home;
using TechnicShop.MVCUI.Areas.Admin.Filters;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class HomeController : Controller
    {

        IAdminBs _adminBS;

        public HomeController(IAdminBs adminBS)
        {
            _adminBS = adminBS;
        }

        [AktifKullaniciFilter]
        [RolFilter("Admin")]
        public IActionResult Index()
        {
            Model.Entity.Admin admin = HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);

            if (admin == null)
            {
                return RedirectToAction("LogIn", "Admin");
            }

            return View();
        }


        public IActionResult Profile()
        {
            ProfileViewModel model = new ProfileViewModel();
            
            //List<Model.Entity.Admin> admins = _adminBS.GetAll().ToList();

            Model.Entity.Admin admin = HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);

            model.Name = admin.Name;
            model.LastName = admin.LastName;
            model.PhoneNumber = admin.PhoneNumber;
            model.BirthDate = admin.BirthDate;
            model.CityId = admin.CityId;
            model.CountryId = admin.CountryId;

            model.Id = admin.Id;


            return View(model);
        }
    }
}
