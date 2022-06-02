using Dominos.Services.Common.Tools.ServiceClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace Dominos.Services.IdentityAccessManagement.Tests.External
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationHelper
    {
        public class IdentityAccessManagementTests
        {
            public CredentialSettings CredentialSettings { get; set; }
        }

        public static IConfigurationRoot GetIConfigurationRoot()
        {
            var settingsFile = "appsettings.json";
             return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFile, optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static IdentityAccessManagementTests GetApplicationConfiguration()
        {
            var configuration = new IdentityAccessManagementTests();
            GetIConfigurationRoot().GetSection(nameof(IdentityAccessManagementTests)).Bind(configuration);
            return configuration;
        }
    }
}

