using Microsoft.AspNetCore.Mvc;
using TechnicShop.Model.Static;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Model.Entity.Admin admin = HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);
            string aktifKullanici = "";

            if (admin != null)
            {
                aktifKullanici = admin.Name + admin.LastName;
            }

            ViewBag.AktifKullanici = aktifKullanici;

            return View();
        }
    }
}
