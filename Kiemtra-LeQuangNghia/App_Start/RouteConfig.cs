
using System.Web.Mvc;
using System.Web.Routing;

namespace Kiemtra_LeQuangNghia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SinhVien", action = "ListSinhVien", id = UrlParameter.Optional }
            );
        }
    }
}
