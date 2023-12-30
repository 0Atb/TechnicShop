using Microsoft.AspNetCore.Mvc;
using TechnicShop.Model.ViewModels.Areas.Admin;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
