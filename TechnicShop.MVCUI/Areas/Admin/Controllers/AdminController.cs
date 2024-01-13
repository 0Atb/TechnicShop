using Microsoft.AspNetCore.Mvc;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Bussiness.Concrete;
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
        public IActionResult LogIn2()
        {
            LogInViewModel logInVm = new LogInViewModel();

            return View(logInVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogIn2(LogInViewModel LogInVm)
        {
            LogInViewModel model = new LogInViewModel();
            if (!ModelState.IsValid) //ModelState.IsValid prop u, Validasyonlardan verinin geçip geçmediği bilgisini verir. Bu sayade sunucuda gereksiz kod çalışmaz.
            {
                ViewBag.Mesaj = "İşlemler Hatalı";
                return View(model);
            }

            Model.Entity.Admin adminUser = _adminBs.Get(x => x.Email == LogInVm.Email && x.Password == LogInVm.Password && x.IsDeleted == false);

            if (adminUser != null)
            {
                //return RedirectToAction("Index", "Home");
                return Redirect("/Admin/Home/Index");
            }

            ViewBag.Mesaj = "Giriş Başarısız";


            return View(LogInVm);
        }

        public IActionResult LogIn()
        {
            LogInViewModel logInVm = new LogInViewModel();

            return View(logInVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult LogIn(LogInViewModel model)
        {
            LogInViewModel logInVm = new LogInViewModel();

            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "Validasyon Hatası";
                return Json(new { result = false, Mesaj = "Validasyon Hatası Oldu." });
            }

            Model.Entity.Admin admin = _adminBs.Get(x => x.Email == model.Email && x.Password == model.Password && x.IsDeleted == false);

            if (admin != null)
            {
                return Json(new { result = true, Mesaj = "Giriş Başarılı"});
            }
            else
            {
                return Json(new { result = false, Mesaj = "Giriş Başarısız" });
            }
        }
    }
}
