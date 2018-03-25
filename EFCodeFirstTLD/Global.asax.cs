using System.Web.Mvc;
using System.Web.Routing;

namespace EFCodeFirstTLD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectDbContext>());
        }
    }
}
