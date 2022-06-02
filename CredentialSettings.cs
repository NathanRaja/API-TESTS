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
       
        public string ApiKey
        {
            get;
            set;
        }

    }
}
