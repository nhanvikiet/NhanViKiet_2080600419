using System.Web;
using System.Web.Mvc;

namespace NhanViKiet_2080600419_LAB03
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
