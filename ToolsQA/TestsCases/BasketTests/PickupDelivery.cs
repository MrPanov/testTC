//Ausing NUnit.Framework;
//using OpenQA.Selenium;
//using System;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{

//    [TestFixture]
//    class Pickup : BaseTest
//    {
//        private BasketPage pickup;



//        [SetUp]

//        public void ChangeTypeDeliveryOnPickupAndClearInvoiceTbl()
//        {
//            pickup = new BasketPage(_browser);
//            _browser.Navigate().GoToUrl("https://my.omega.page/#/app/basket");
//            //pickup.refreshJournal();
//            pickup.RemoveAllInvoicesInJournalBasket();
//            pickup.InputBasketAddPosition("4610947337");
//            pickup.OpenDdlWarehouses();
//            pickup.SelectParamCity("Харьков");            
//            ScrollUp();
//            pickup.SaveInvoice();
//        }



//        [Test]
//        public void ReservateInvoice()
//        {
            
//            pickup.OpenDdlSlctshipmentType();
//            WaitForElementToBeClickableXpath("//*[@class='selectize-dropdown-content']//*[contains(text(),'Самовывоз')]");
//            pickup.ClickShipmentTypePickup();
//            pickup.ClickOnButtonReservationInvoiceInOrder();
//            WaitForElementIsVisibleXpath("//*[@id='openHeaderInvoice']//td[2]//*[contains(text(),'Зарезервирован')]");
//            Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Зарезервирован"));

//        }

//        //[Test]
//        //public void SaveInvoice()
//        //{
//        //    //pickup.SaveInvoice();
//        //    //Thread.Sleep(1500);
            
//        //    pickup.OpenDdlSlctshipmentType();
//        //    WaitForElementToBeClickableXpath("//*[@class='selectize-dropdown-content']//*[contains(text(),'Самовывоз')]");
//        //    pickup.ClickShipmentTypePickup();
//        //    pickup.ClickOnButtonSaveInvoiceInOrder();
//        //    WaitForElementIsVisibleXpath("//*[@id='openHeaderInvoice']//td[2]//*[contains(text(),'Сохранён')]");
//        //    Assert.IsTrue(_driver.FindElement(By.CssSelector(".tab-pane.active .basketTabInvoice")).Text.Contains("Сохранён"));

//        //}

//    }
//}
