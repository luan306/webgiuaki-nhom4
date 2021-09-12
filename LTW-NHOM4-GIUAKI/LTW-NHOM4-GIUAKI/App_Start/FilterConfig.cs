using System.Web;
using System.Web.Mvc;

namespace LTW_NHOM4_GIUAKI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
