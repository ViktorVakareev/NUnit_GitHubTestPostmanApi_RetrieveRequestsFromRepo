using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;


namespace API_Tests_GitHub
{
    public class Tests
    {
        const string userName = "ViktorVakareev";
        const string password = "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";

        [SetUp]
        public void Setup()
        {
        }

        [Test]      
        public void Test_GitHubIssues_RetrieveAllIssuesFromRepo()
        {
            var client = new RestClient("http://api.github.com/repos/testnakov/test-nakov-repo/issues");
            client.Timeout = 3000;
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
           
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            // dynamic json = Json.Decode(response.Content);   //return json array[]

            Assert.IsTrue(response.ContentType.StartsWith("application/json"));

           
        }
       
    }

}