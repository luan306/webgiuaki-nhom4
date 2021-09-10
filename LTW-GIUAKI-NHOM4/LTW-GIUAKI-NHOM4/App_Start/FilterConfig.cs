using System.Web;
using System.Web.Mvc;

namespace LTW_GIUAKI_NHOM4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
