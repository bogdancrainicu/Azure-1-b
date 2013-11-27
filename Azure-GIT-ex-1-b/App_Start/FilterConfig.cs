using System.Web;
using System.Web.Mvc;

namespace Azure_GIT_ex_1_b
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}