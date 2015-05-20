using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using CRMproject.Models;

namespace CRMproject
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterMicrosoftClient(
                clientId: "000000004C14EC6F",
                clientSecret: "9A7pCh2b-XbKSwBuhvchfMa6FzjQt0IM");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "346534482222832",
                appSecret: "fdbc7bf2deb8ab3ce121086bb0e40601");

          //  OAuthWebSecurity.RegisterGoogleClient();

        }
    }
}
