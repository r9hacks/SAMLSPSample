using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

using ComponentSpace.SAML2.Notifications;
using ComponentSpace.SAML2.Protocols;
using SAMLSPSample.SAMLSP;

namespace SAMLSPSample
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SAMLObservable.Subscribe(new SAMLObserver());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            try
            {
                string s =HttpContext.Current.Request.Headers.ToString();
                System.Diagnostics.Debug.WriteLine("args1: {0} ", s);
                HttpContext.Current.Request.Headers["Accept-Encoding"] = "";
                HttpContext.Current.Request.Headers.Remove("Accept-Encoding");
                HttpContext.Current.Response.Headers.Remove("Accept-Encoding");
                s = HttpContext.Current.Request.Headers.ToString();
                System.Diagnostics.Debug.WriteLine("args2: {0} ", s);

            }
            catch (Exception) { }
        }
    }
}