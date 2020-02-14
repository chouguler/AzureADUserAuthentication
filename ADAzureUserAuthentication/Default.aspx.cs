using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;

namespace ADAzureUserAuthentication
{
    public partial class Default : System.Web.UI.Page
    {

        public void SignIn()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.Current.GetOwinContext().Authentication.Challenge(
                   new AuthenticationProperties { },
                   OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SignIn();
            return;
        }
    }
}