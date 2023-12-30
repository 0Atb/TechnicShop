using Microsoft.AspNetCore.Mvc;

namespace TechnicShop.MVCUI.Areas.Admin.ViewComponents
{
    public class ContentViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
