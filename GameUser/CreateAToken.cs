using System;
using System.IO;
using System.Net;
using Dominos.Services.IdentityAccessManagement.Tests.External;
using Dominos.Services.IdentityAccessManagement.Tests.External.E2E;
using NUnit.Framework;
using RestSharp;
//using Shouldly;

namespace GameAPI.External.E2E
{
    [TestFixture]

    public class CreateATokenAndUserlogin
    {
        public CredentialSettings credentialSettings;


        [Test, Order(1)]
        public void CreateAToken()
        {
            credentialSettings = ConfigurationHelper.GetApplicationConfiguration().CredentialSettings;
            RestClient client = new RestClient(credentialSettings.BaseUrlAU);
            var request = new RestRequest("/auth/user/register", Method.POST);
            request.AddHeader("X-API-KEY", credentialSettings.ApiKey);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            Random rnd = new Random();

            IRestRequest restRequest = (RestRequest)request.AddJsonBody(new UserReg()
            {
                username = "nathna4",
                password = "Midhura04",
            });

            IRestResponse response = client.Execute(request);
            //response.StatusCode.ShouldBe(HttpStatusCode.OK);
            response.StatusCode.Equals(200);

        }

        [Test, Order(2)]
        public void UserLogin()
        {
            credentialSettings = ConfigurationHelper.GetApplicationConfiguration().CredentialSettings;
            RestClient client = new RestClient(credentialSettings.BaseUrlAU);
            var request = new RestRequest("/auth/user/login", Method.POST);
            request.AddHeader("X-API-KEY", credentialSettings.ApiKey);
            request.AddHeader("Content-Type", "application/json");
            var payload = File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/E2E/Payloads/Uselogin.json");
            IRestResponse response_UserLogin = client.Execute(request);
            response_UserLogin.StatusCode.Equals(200);


        }


    }
}