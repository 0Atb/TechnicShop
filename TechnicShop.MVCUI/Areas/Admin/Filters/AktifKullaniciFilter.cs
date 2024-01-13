using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TechnicShop.Model.Static;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.Filters
{
    public class AktifKullaniciFilter:ActionFilterAttribute,IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            //Not: Burası bu filtrenin uygulandığı action metod çalıştırılmadan önce çalışacak kodların yazıldığı yerdir.

            Model.Entity.Admin admin = context.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);

            if (admin == null)
            {
                context.Result = new RedirectResult("/Admin/Admin/LogIn");
            }


            base.OnActionExecuting(context);
        }

        //aktifkullanicifilter üzerine bunu yazdığında action ikisinin arasında çalışıyor.

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //Not: Burası da bu filterinin uygulandığı action method çalıştırıldıktan sonra çalışacak kodların yazılacağı yerdir.
            base.OnActionExecuted(context);
        }



    }
}
