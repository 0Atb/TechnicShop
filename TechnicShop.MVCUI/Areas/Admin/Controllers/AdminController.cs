using Microsoft.AspNetCore.Mvc;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Model.ViewModels.Areas.Admin;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        IAdminBs _adminBs;

        public AdminController(IAdminBs adminBs)
        {
            _adminBs = adminBs;
        }
        public IActionResult LogIn()
        {
            LogInViewModel logInVm = new LogInViewModel();

            return View(logInVm);
        }

        [HttpPost]
        public IActionResult LogIn(LogInViewModel LogInVm) 
        {
            LogInViewModel model = new LogInViewModel();

            Model.Entity.Admin adminUser = _adminBs.Get(x=>x.Email == LogInVm.Email && x.Password == LogInVm.Password && x.IsDeleted==false);

            if (adminUser != null)
            {
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("/Admin/Home/Index");
            }

            ViewBag.Mesaj = "Giriş Başarısız";


            return View(LogInVm);
        }
    }
}
