using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Security;

using ComponentSpace.SAML2;
using ComponentSpace.SAML2.Data;

namespace SAMLSPSample.SAMLSP
{
    public partial class AssertionConsumerService : System.Web.UI.Page
    {
        public const string AttributesSessionKey = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            bool isInResponseTo = false;
            string partnerIdP = null;
            string authnContext = null;
            string userName = null;
            IDictionary<string, string> attributes = null;
            string targetUrl = null;

            // Receive and process the SAML assertion contained in the SAML response.
            // The SAML response is received either as part of IdP-initiated or SP-initiated SSO.
            SAMLServiceProvider.ReceiveSSO(Request, out isInResponseTo, out partnerIdP, out authnContext, out userName, out attributes, out targetUrl);

            // If no target URL is provided, provide a default.
            if (targetUrl == null)
            {
                targetUrl = "~/UserInfo";
            }

            // Login automatically using the asserted identity.
            // This example uses forms authentication. Your application can use any authentication method you choose.
            // There are no restrictions on the method of authentication.
            FormsAuthentication.SetAuthCookie(userName, false);

            // Save the attributes.
            Session[AttributesSessionKey] = attributes;

            // Redirect to the target URL.
            Response.Redirect(targetUrl, false);
        }
    }
}
