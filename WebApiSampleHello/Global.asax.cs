using System.Web.Http;

namespace WebApiSampleHello
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);            
            
        }
    }
}
