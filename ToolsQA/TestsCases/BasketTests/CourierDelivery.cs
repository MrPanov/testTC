//using NUnit.Framework;
//using OpenQA.Selenium;
//using System;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{

//    [TestFixture]
//    class CourierService : BaseTest
//    {
//        private BasketPage courierservice;



//        [SetUp]

//        public void ChangeTypeDeliveryOnCourierServiceAndClearInvoiceTbl()
//        {
//            courierservice = new BasketPage(_browser);
//            _browser.Navigate().GoToUrl("https://my.omega.page/#/app/basket");
//            WaitForElementIsVisibleID("buttonBasketGo");
//            //courierservice.refreshJournal();
//            courierservice.RemoveAllInvoicesInJournalBasket();
//            courierservice.InputBasketAddPosition("oc90");
//            courierservice.OpenDdlWarehouses();
//            courierservice.LoadElseInDdlWarehouses();
//            courierservice.SelectParamCity("Днепр");
//            ScrollUp();
            
           


//        }



//        [Test]
//        public void ReservateInvoice()
//        {
            
//            courierservice.ReservationInvoice();
//            WaitForElementIsVisibleXpath("(//a[@id='openHeaderInvoice']//*[contains(text(),'Зарезервирован')])[1]");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Зарезервирован"));

//        }

//        //[Test]
//        //public void SaveInvoice()
//        //{
//        //    courierservice.SaveInvoice();
//        //    //WaitForElementIsVisibleCSS(".tab-pane.active .basketTabInvoice");
//        //    WaitForElementIsVisibleXpath("(//a[@id='openHeaderInvoice']//*[contains(text(),'Сохранён')])[1]");
//        //    Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Сохранён"));
//        //}
//    }
//}
