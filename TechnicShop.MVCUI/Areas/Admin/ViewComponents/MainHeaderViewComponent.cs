using Microsoft.AspNetCore.Mvc;

namespace TechnicShop.MVCUI.Areas.Admin.ViewComponents
{
    public class MainHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
