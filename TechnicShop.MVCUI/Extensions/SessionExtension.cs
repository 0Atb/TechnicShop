using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace TechnicShop.MVCUI.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession sesion, string key, object value)
        {
            string json = JsonConvert.SerializeObject(value,Formatting.None,new JsonSerializerSettings //bir stringi(stringden kasıt json formatı olması) class formatına çevirmek istiyorsak serialize etmek lazım. 
            {
                ReferenceLoopHandling= ReferenceLoopHandling.Ignore
            });

            if (!string.IsNullOrEmpty(json))
            {
                sesion.SetString(key, json);
            }
        }

        public static T GetObject<T>(this ISession sesion, string key)
            where T : class
        {
            string json = sesion.GetString(key);
            if (!string.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<T>(json); //bir classı string formatına çevirmek istiyorsak serialize etmekmiz lazım.
            }
            else
            {
                return null;
            }
        }
    }
}
