using System;
using System.Web.Security;

using ComponentSpace.SAML2;

namespace SAMLSPSample.SAMLSP
{
    public partial class SLOService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Receive the single logout request or response.
            // If a request is received then single logout is being initiated by the identity provider.
            // If a response is received then this is in response to single logout having been initiated by the service provider.
            bool isRequest = false;
            string logoutReason = null;
            string partnerIdP = null;
            string relayState = null;

            SAMLServiceProvider.ReceiveSLO(Request, out isRequest, out logoutReason, out partnerIdP, out relayState);

            //System.Diagnostics.Debug.WriteLine("SLOService !!!!!!!!!!!!!!!!!!!!!!!!!!");
            //System.Diagnostics.Debug.WriteLine("isRequest: {0} ", isRequest);


            //this if means the ReceiveSLO is a Request not Response
            //the else means the ReceiveSLO is a Response

            if (isRequest)
            {
                // Logout locally.
                FormsAuthentication.SignOut();

                // Respond to the IdP-initiated SLO request indicating successful logout.
                SAMLServiceProvider.SendSLO(Response, null);
            }
            else
            {           

                // SP-initiated SLO has completed.
                //FormsAuthentication.RedirectToLoginPage();
                Response.Redirect("loginSP.aspx");


            }

            // To check the StatusCode Value in the SAML Response you must  subscribe to SAML notifications and access the logout response directly to check the status.
            // see SAMLObserver.aspx.cs and Global.aspx where we subscribe ---SAMLObservable.Subscribe(new SAMLObserver());---

        }
    }
}