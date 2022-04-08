//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using RestSharp;
//using System;
//using System.Threading;

//namespace ApiTest
//{
//    [TestClass]
//    public class APITestBase
//    {
//        private const string mainApiUrl = "https://public.omega-auto.biz/public/api/v1.0";

//        protected RestClient client;
//        protected ManualResetEvent resetEvent;
//        protected RestRequest request;
//        protected IRestResponse response;

//        [TestInitialize]
//        public void Setup()
//        {
//            client = new RestClient(mainApiUrl);

//            resetEvent = new ManualResetEvent(false);
//        }

//        public void SendRequest()
//        {
//            client.ExecuteAsync(request, (resp, asyncHandle) =>
//            {
//                response = resp;
//                resetEvent.Set();
//            });

//            resetEvent.WaitOne();
//        }

//        [TestCleanup]
//        public void TearDown()
//        {
//            resetEvent.Close();
//        }
//    }
//}
