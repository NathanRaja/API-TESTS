using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominos.Services.IdentityAccessManagement.Tests.External
{
    [ExcludeFromCodeCoverage]
    public class CredentialSettings
    { 
        public string BaseUrlAU
        {
            get;
            set;
        }
        public string BaseUrlEU
        {
            get;
            set;
        }
        public string BaseUrlJP
        {
            get;
            set;
        }
        public string ApiKey
        {
            get;
            set;
        }
      
        public string ApiKey_Auth
        {
            get;
            set;
        }
        public string BaseUrlOKTA
        {
            get;
            set;
        }
        public string ApiKeyOKTA
        {
            get;
            set;
        }

        public string Auth_BaseUrlAU
        {
            get;
            set;
        }
        public string Auth_BaseUrlEU
        {
            get;
            set;
        }
        public string Auth_BaseUrlJP
        {
            get;
            set;
        }

        public string DbUserName
        {
            get;
            set;
        }
        public string DbConnPassword
        {
            get;
            set;
        }
    }
}
