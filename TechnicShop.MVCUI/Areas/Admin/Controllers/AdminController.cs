using Infrastructure.CrossCuttingConcern.MailOp;
using Microsoft.AspNetCore.Mvc;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Bussiness.Concrete;
using TechnicShop.Model.Static;
using TechnicShop.Model.ViewModels.Areas.Admin;
using TechnicShop.MVCUI.Areas.Admin.Filters;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminBs _adminBs;
        private readonly ISessionManager sessionManager;

        public AdminController(IAdminBs adminBs, ISessionManager _sessionManager)
        {
            _adminBs = adminBs;
            sessionManager = _sessionManager;
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
                //HttpContext.Session["aktifkullanici"] = 123;


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

            Model.Entity.Admin admin = _adminBs.Get(x => x.Email == model.Email && x.Password == model.Password && x.IsDeleted == false, "AdminRoles", "AdminRoles.Role");

            if (admin != null)
            {

                sessionManager.AktifKullanici = admin;

                return Json(new { result = true, Mesaj = "Giriş Başarılı" });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Giriş Başarısız" });
            }
        }


        public IActionResult NonAuthorization()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            sessionManager.AktifKullanici = null;

            return RedirectToAction("LogIn", "Admin");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult ForgotPassword(ForgotPasswordViewModel forgotPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "İşlemler Hatalı";
                return Json(new { result = false, Mesaj = "Validasyon Hatası Oldu." });
            }

            Model.Entity.Admin admin = null;

            if (forgotPasswordViewModel.EmailOrPhoneNumber.Contains("@"))
            {
                admin = _adminBs.Get(x => x.Email == forgotPasswordViewModel.EmailOrPhoneNumber);
            }
            else
            {
                admin = _adminBs.Get(x => x.PhoneNumber == forgotPasswordViewModel.EmailOrPhoneNumber);
            }

            if (admin != null)
            {
                MailManager.Send(admin.Email, "Şifre Değiştirme", "Merhaba Sayin : " + admin.Name + " " + admin.LastName + "</br> Şifrenizi Değiştirmek İçim Lütfen <a href='" + Keys.SITEADDRESS + "Admin/Admin/UpdatePassword?UniqueId=" + admin.UniqueId + "'>Tıklayınız</a> ");


                return Json(new { result = true, Mesaj = "Şifre Değiştirme Linki Mail Adresinize Gönderildi. Lütfen Mailinizi Kontrol Ediniz." });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Lütfen Bilgilerinizi Kontrol Ediniz." });
            }
        }

        public IActionResult UpdatePassword(string UniqueId)
        {
            UpdatePasswordViewModel model = new UpdatePasswordViewModel();

            model.UniqueId = UniqueId;

            Model.Entity.Admin admin = _adminBs.Get(x => x.UniqueId.ToString() == model.UniqueId);

            if (admin == null)
            {
                return RedirectToAction("DangerZone", "Admin");
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult UpdatePassword(UpdatePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mesaj = "İşlemler Hatalı";
                return Json(new { result = false, Mesaj = "Validasyon Hatası" });
            }


            Model.Entity.Admin admin = _adminBs.Get(x => x.UniqueId.ToString() == model.UniqueId);

            if (admin != null && model.Password == model.ConfirmPassword)
            {
                admin.UniqueId = Guid.NewGuid(); //sql de newid() ile aynı quid id yi üretir.
                admin.Password = model.Password;

                _adminBs.Update(admin);

                return Json(new { result = true, Mesaj = "Şifreniz Başarıyla Değişti. Giriş Yapabilirsiniz." });
            }
            else
            {
                return Json(new { result = false, Mesaj = "Ip Adresiniz Kayıt Ediliyor. Lütfen Yetksiz İşlem Yapmayınız." });
            }
        }


        public IActionResult DangerZone()
        {
            return View();
        }

    }
}
