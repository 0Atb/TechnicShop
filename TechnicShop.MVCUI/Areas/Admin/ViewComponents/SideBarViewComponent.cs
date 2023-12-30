using Microsoft.AspNetCore.Mvc;

namespace TechnicShop.MVCUI.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
