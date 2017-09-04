using System.Web;
using System.Web.Mvc;

namespace ci_web_mvc_.net4._6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
