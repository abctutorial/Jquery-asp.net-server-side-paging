using System.Web;
using System.Web.Mvc;

namespace Jquery_Mvc_Paging
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
