using System.Web;
using System.Web.Mvc;

namespace TP2_Mod5_Pizza
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
