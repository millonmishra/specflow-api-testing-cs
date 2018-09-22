using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace APIAutomationTestSuite.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointTodos(string endpoint)
        {
            RestAPIHelper.SetURL(endpoint);
        }

        [When(@"I call get mthod for this api")]
        public void WhenICallGetMthodForThisApi()
        {
            RestAPIHelper.CreateRequest();
        }

        [Then(@"i get response in json format")]
        public void ThenIGetResponseInJsonFormat()
        {
            var response = RestAPIHelper.GetResponse();
            Console.WriteLine(response.Content);
        }

        [When(@"I call get mthod for this api using (.*)")]
        public void WhenICallGetMthodForThisApiUsingTodoId(string todoId)
        {
            RestAPIHelper.CreateRequest(todoId);
        }


    }
}
