//using NUnit.Framework;
//using OpenQA.Selenium;
//using System;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{

//    [TestFixture]
//    class ScheduledDelivery : BaseTest
//    {
//        private BasketPage scheduledDelivery;



//        [SetUp]
//        public void ChangeTypeDeliveryOnSchedukedAndClearInvoiceTbl()
//        {
//            scheduledDelivery = new BasketPage(_browser);
//            _browser.Navigate().GoToUrl("https://my.omega.page/#/app/basket");
//            scheduledDelivery.RemoveAllInvoicesInJournalBasket();
//            scheduledDelivery.InputBasketAddPosition("4610947337");
//            scheduledDelivery.OpenDdlWarehouses();
//            scheduledDelivery.SelectParamCity("Харьков");
//            scheduledDelivery.SaveInvoice();
//            ScrollUp();


//        }






//        //[Test]
//        //public void SaveInvoice()
//        //{

//        //    WaitForElementToBeClickableID("accountSecondTabUser");
//        //    scheduledDelivery.OpenDdlSlctshipmentType();
//        //    scheduledDelivery.ClickShipmentTypeScheduled();

//        //    //scheduledDelivery.SelectSchedukedDeliveryInDdlDelivery();
//        //    WaitForElementToBeClickableID("accountSecondTabUser");
//        //    WaitForElementIsVisibleXpath("(//a[@id='openHeaderInvoice']//*[contains(text(),'Сохранён')])[1]");
//        //    Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Сохранён"));

//        //}



//        [Test]
//        public void ReservateInvoice()
//        {

//            WaitForElementToBeClickableID("accountSecondTabUser");
//            scheduledDelivery.OpenDdlSlctshipmentType();
//            scheduledDelivery.ClickShipmentTypeScheduled();
//            scheduledDelivery.ClickOnButtonReservationInvoiceInOrder();
//            WaitForElementIsVisibleXpath("(//a[@id='openHeaderInvoice']//*[contains(text(),'Зарезервирован')])[1]");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Зарезервирован"));
//        }

//    }
//}
