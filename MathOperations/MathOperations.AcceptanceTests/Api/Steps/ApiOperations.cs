using NUnit.Framework;
using ProjectoParaElCurso1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace AccptanceTests.Api.Steps
{
    [Binding]
    public class ApiOperations
    {
        private Operation _request = new Operation();
        private double _result;

        [Given(@"I have set (.*) in a request as first number")]
        public void GivenIHaveSetInARequestAsFirstNumber(string number1)
        {
            _request.Number1 = double.Parse(number1);
        }

        [Given(@"I have set (.*) in a request as second number")]
        public void GivenIHaveSetInARequestAsSecondNumber(string number2)
        {
            _request.Number2 = double.Parse(number2);
        }

        [When(@"I send the ""(.*)"" request")]
        public void WhenISendTheRequest(string requestUrl)
        {
            var restClient = new RestClient(ConfigurationManager.AppSettings["WebUrl"]);

            //var request = new HttpRequestWrapper()
            //                   .SetMethod(Method.POST)
            //                   .SetResourse("/api/" + requestUrl)
            //                  .AddJsonContent(_request);

            var restRequest = new RestRequest();
            restRequest.Method = Method.POST;
            restRequest.Resource = "/api/" + requestUrl;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddBody(_request);

            var restResponse = restClient.Execute(restRequest);
            _result = JsonConvert.DeserializeObject<double>(restResponse.Content);
        }

        [Then(@"the result should be (.*) on the response")]
        public void ThenTheResultShouldBeOnTheResponse(string result)
        {
            Assert.AreEqual(double.Parse(result), _result);
        }

    }
}
