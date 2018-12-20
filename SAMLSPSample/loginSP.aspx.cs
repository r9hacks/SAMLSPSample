using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using ComponentSpace.SAML2;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace SAMLSPSample
{
    public static class AppSettings
    {
        public const string PartnerIdP = "PartnerIdP";
        public const string Attribute = "Attribute";
        public const string SubjectName = "SubjectName";
        public const string TargetUrl = "TargetUrl";
    }

    public static class SAMLConfig
    {
        public static string getPartnerIdP()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saml.config"));
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("ns", "urn:componentspace:SAML:2.0:configuration");
            var node = doc.SelectSingleNode("ns:SAMLConfiguration", namespaces);
            XmlNodeList xnl = node.ChildNodes;
            for (int i = 0; i < xnl.Count; i++)
            {
                if (xnl.Item(i).GetType() == typeof(XmlElement))
                {
                    XmlElement xe = (XmlElement)xnl.Item(i);
                    if (xe.Name == "PartnerIdentityProvider")
                    {
                        string idpName = xe.Attributes["Name"].Value;
                        return idpName;
                    }
                }
            }
            return WebConfigurationManager.AppSettings[AppSettings.PartnerIdP];
        }
    }

    public partial class loginSP : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ssoLinkButton_Click(object sender, EventArgs e)
        {

            string partnerIdP = WebConfigurationManager.AppSettings[AppSettings.PartnerIdP];
            SAMLServiceProvider.InitiateSSO(Response, null, partnerIdP);

        }
    }
}