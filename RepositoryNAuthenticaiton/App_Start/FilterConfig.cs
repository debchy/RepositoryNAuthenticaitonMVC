using System.Web;
using System.Web.Mvc;

namespace RepositoryNAuthenticaiton
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new CMS.Filters.RecaptchaFilter());
        }
    }
}
