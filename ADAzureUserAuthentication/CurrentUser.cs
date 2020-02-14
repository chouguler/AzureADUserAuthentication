using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADAzureUserAuthentication
{
    public class CurrentUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool Logon(string sEmail)
        {
            //validate user email in your application database
            return true;
        }
    }
}