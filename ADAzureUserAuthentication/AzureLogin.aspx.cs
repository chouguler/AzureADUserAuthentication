using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Web;
using System.Data;

namespace ADAzureUserAuthentication
{
    public partial class AzureLogin : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                try
                {
                    string id_token = Request.QueryString["id_token"];

                    if (!string.IsNullOrEmpty(id_token))
                    {
                        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                        var tempToken = handler.ReadToken(id_token) as JwtSecurityToken;
                        string EmailId = "";

                        if (tempToken.Payload.ContainsKey("unique_name"))
                            EmailId = tempToken.Payload["unique_name"].ToString();

                        if (EmailId.Contains("#"))
                        {
                            string[] claims = EmailId.Split('#');
                            EmailId = claims[1].ToString();
                        }

                        CurrentUser currentUser = new CurrentUser();
                        if (currentUser.Logon(EmailId))
                        {
                           Session.Remove("CurrentUser");
                           Session.Add("CurrentUser", currentUser);
                            try
                            {
                                Response.Redirect("Home.aspx");
                            }
                            catch { }
                                           
                        }
                        else
                        {
                            LabelMsg.Text = "You are not allowed to access this application. Pls contact administrator.";
                            return;
                        }                       
                    }
                    else
                        Response.Redirect("~/AzureLogout.aspx", true);                  

                }
                catch (Exception ex)
                {
                    LabelMsg.Text = ex.ToString();
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", true);
        }
    }
}