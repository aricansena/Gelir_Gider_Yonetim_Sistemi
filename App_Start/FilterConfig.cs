using System.Web;
using System.Web.Mvc;

namespace Gelir_Gider_Yonetim_Sistemi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
