using System.Web;
using System.Web.Mvc;

namespace MVC_webgrid_data_bind_display_from_database_table
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
