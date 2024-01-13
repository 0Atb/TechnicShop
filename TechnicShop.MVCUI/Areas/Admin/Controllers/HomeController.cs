using Microsoft.AspNetCore.Mvc;
using TechnicShop.Model.ViewModels.Areas.Admin;
using TechnicShop.MVCUI.Areas.Admin.Filters;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AktifKullaniciFilter]
    [RolFilter("Admin", "Muhasebe")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
    }
}
