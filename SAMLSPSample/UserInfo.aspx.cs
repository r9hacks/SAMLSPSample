using ComponentSpace.SAML2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAMLSPSample
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IDictionary<string, string> attributes = (IDictionary<string, string>)Session[SAMLSP.AssertionConsumerService.AttributesSessionKey];
            if(attributes == null)
            {
                return;
            }
            string htmlTable = "<table id='myTable'> <tr class='header'><th style = 'width:40%;'> Attribute </th><th style = 'width:60%;'> Value </th> </tr>";

            
            foreach (KeyValuePair<string, string> entry in attributes)
            {
                // do something with entry.Value or entry.Key
                htmlTable += "<tr><td>" + entry.Key + "</td><td>" + entry.Value + "</td></tr>";
            }

            htmlTable += "</table>";
            lblTable.Text = htmlTable;
        }

        private class AttributeDataSource
        {
            private string attributeName;
            private string attributeValue;

            public static IList<AttributeDataSource> Get(IDictionary<string, string> attributes)
            {
                IList<AttributeDataSource> attributeDataSources = new List<AttributeDataSource>();

                foreach (string attributeName in attributes.Keys)
                {
                    attributeDataSources.Add(new AttributeDataSource(attributeName, HttpUtility.HtmlEncode(attributes[attributeName])));
                }

                return attributeDataSources;
            }

            private AttributeDataSource(string attributeName, string attributeValue)
            {
                this.attributeName = attributeName;
                this.attributeValue = attributeValue;
            }

            public string AttributeName
            {
                get
                {
                    return attributeName;
                }
            }

            public string AttributeValue
            {
                get
                {
                    return attributeValue;
                }
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            
            // Logout locally.
            FormsAuthentication.SignOut();

            if (SAMLServiceProvider.CanSLO(WebConfigurationManager.AppSettings[AppSettings.PartnerIdP]))
            {
                // Request logout at the identity provider.
                string partnerIdP = WebConfigurationManager.AppSettings[AppSettings.PartnerIdP];
                SAMLServiceProvider.InitiateSLO(Response, null, null, partnerIdP);
            }
            else
            {

                Response.Redirect("loginSP.aspx");

            }

        }
    }
}