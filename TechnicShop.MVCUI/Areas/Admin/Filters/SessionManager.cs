using TechnicShop.Model.Static;
using TechnicShop.MVCUI.Extensions;

namespace TechnicShop.MVCUI.Areas.Admin.Filters
{
    public class SessionManager : ISessionManager
    {
        IHttpContextAccessor httpContextAccessor;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Model.Entity.Admin AktifKullanici 
        {
            get 
            {
                return httpContextAccessor.HttpContext.Session.GetObject<Model.Entity.Admin>(SessionKeys.AktifKullanici);
            }

            set
            {
                httpContextAccessor.HttpContext.Session.SetObject(SessionKeys.AktifKullanici, value);
            }
        }
    }
}
