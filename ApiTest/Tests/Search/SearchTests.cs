//using System;
//using System.Threading;
//using ApiTest.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Newtonsoft.Json;
//using RestSharp;

//namespace ApiTest
//{
//    [TestClass]
//    public class SearchTests : APITestBase
//    {
//        private const int TotalProductsExpect = 1748;
//        private const int TotalProductsExpectZero = 0;
//        private const string SearchUrl = "product/search";

//        [TestMethod]
//        public void TestSearchVazFilterShouldBeSuccess()
//        {
//            request = new RestRequest(SearchUrl, Method.POST);
//            request.AddJsonBody("{\"SearchPhrase\":\"фильтр ваз\",\"Rest\": 0,\"From\": 0,\"Count\": 20,\"Key\":\"RQzSCdY99JgV0kMtSYx0KTcE9bdWmhai\"}");

//            SendRequest();

//            var data = JsonConvert.DeserializeObject<SearchResult>(response.Content);
                        
//            Assert.IsNotNull(response.Content);
//            Assert.AreEqual(TotalProductsExpect, data.Total);          
//        }

//        [TestMethod]
//        public void TestSearchVazFilterShouldFail()
//        {
//            request = new RestRequest(SearchUrl, Method.POST);
//            request.AddJsonBody("{\"SearchPhrase\":\"вазафил\",\"Rest\": 0,\"From\": 0,\"Count\": 20,\"Key\":\"RQzSCdY99JgV0kMtSYx0KTcE9bdWmhai\"}");

//            SendRequest();

//            var data = JsonConvert.DeserializeObject<SearchResult>(response.Content);

//            Assert.IsNotNull(response.Content);
//            Assert.AreEqual(TotalProductsExpectZero, data.Total);
//        }
//    }
//}

