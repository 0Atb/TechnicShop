using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TechnicShop.Model.Static;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.Filters
{
    public class RolFilter : ActionFilterAttribute
    {
        string[] ctrlRoles;

        public RolFilter(params string[] ctrlRoles)
        {
            this.ctrlRoles = ctrlRoles;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //sesion a giriş yapan kişinin bilgilerini bul
            Model.Entity.Admin admin = context.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);

            //Giriş yapan kişinin rollerini getir
            string[] Rols = new string[admin.AdminRoles.Count]; //Aktif Kullanıcının etkin rolünün sayısını bul

            for (int i = 0; i < admin.AdminRoles.Count; i++)
            {
                Rols[i] = admin.AdminRoles.ToList()[i].Role.RoleName;
            }

            bool Authorization = false;

            foreach (string role in Rols) //Aktif Kullanıcının etkin rolleri
            {
                foreach (string roles in ctrlRoles) //Conterollerden gelen izin verilen roller
                {
                    if (role==roles) //Aktif kullanıncının rollerinde controllerdan izin verilen roller var mı.
                    {
                        Authorization = true; 
                    }
                }
            }

            if (!Authorization)
            {
                context.Result = new RedirectResult("/Admin/Admin/NonAuthorization");
            }


            base.OnActionExecuting(context);
        }



    }
}
