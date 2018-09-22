using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace APIAutomationTestSuite
{
    public static class RestAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static String baseURL = "https://jsonplaceholder.typicode.com/";

        public static RestClient SetURL( string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest CreateRequest(string todoId)
        {
            var resource = todoId;
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }

        public static RestRequest UpdateRequest(string todoId)
        {
            var resource = todoId;
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
    }
}
