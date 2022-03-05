using System.Web.Mvc;

namespace TeamHorizon.Website
{
    public class MvcApplication : Sitecore.Web.Application
    {
        protected void Application_Start()
        {
            MvcHandler.DisableMvcResponseHeader = true;
        }
    }
}
