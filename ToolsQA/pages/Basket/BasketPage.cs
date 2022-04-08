using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace ToolsQA.pages
{
    public class BasketPage
    {
        private IWebDriver _driver;

        public BasketPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/button")]
        [CacheLookup]
        public IList<IWebElement> RemoveButtonInPopupNotification { get; set; }


        [FindsBy(How = How.Id, Using = "navbarBasket")]
        [CacheLookup]
        private IWebElement NavabarBasket { get; set; }

        [FindsBy(How = How.Id, Using = "inputBasketAddCardNumber")]
        [CacheLookup]
        private IWebElement InputBasketAddCard { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketCreateInvoice")]
        [CacheLookup]
        private IWebElement ButtonSaveInvoice { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketReservationInvoice")]
        [CacheLookup]
        private IWebElement ButtonReservationInvoice { get; set; }




        [FindsBy(How = How.Id, Using = "tblBasket")]
        [CacheLookup]
        public IWebElement BasketTable { get; set; }

        [FindsBy(How = How.Id, Using = "accordionInvoiceList")]
        [CacheLookup]
        public IWebElement InvoiceTable { get; set; }

        [FindsBy(How = How.Id, Using = "accordionInvoiceList")]
        [CacheLookup]
        public IWebElement TblInvoice { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketGo")]
        [CacheLookup]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-darkorange.btn-sm")]
        [CacheLookup]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketRemoveInvoice")]
        [CacheLookup]
        public IWebElement ButtonRemoveInvoiceFromBasket { get; set; }

        [FindsBy(How = How.Id, Using = "accountSecondTabUser")]
        [CacheLookup]
        public IWebElement InvoiceJournalTab { get; set; }
        

        [FindsBy(How = How.CssSelector, Using = ".tab-pane.active button[id = 'buttonBasketReservationInvoice']")]
        [CacheLookup]
        public IWebElement ButtonReservationInvoiceInOrder { get; set; }

        [FindsBy(How = How.Id, Using = "buttonBasketSaveInvoice")]
        [CacheLookup]
        public IWebElement ButtonSaveInvoiceInOrder { get; set; }
        //*[@id='tblBasket']/div[5]/div/div/div/div/div[1]/div/div[2]/table
        [FindsBy(How = How.XPath, Using = "//span[2]/b/a/i")]
        [CacheLookup]
        public IWebElement RefreshShipmentDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='selectize-dropdown-content']//*[contains(text(),'Плановая')]")]
        [CacheLookup]
        public IWebElement SelectShipmentTypeScheduled { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//*[@class='selectize-dropdown-content']//*[contains(text(),'Самовывоз')]")]
        [CacheLookup]
        public IWebElement SelectShipmentTypePickup { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='slctshipmentType'])[1]")]
        [CacheLookup]
        public IWebElement SlctshipmentTypeDdl { get; set; }

        public void OpenDdlWarehouses()
        {
            IWebElement DdlWarehouses = _driver.FindElement(By.XPath("//*[@class='btn btn-default dropdown-toggle ']"));
            DdlWarehouses.Click();
        }

        public void LoadElseInDdlWarehouses()
        {
            IWebElement ElseInDdlWarehouses = _driver.FindElement(By.XPath("//*[@ng-click='showRegionalWarehouses($event)']"));
            ElseInDdlWarehouses.Click();
        }

        public void SelectParamCity(string selector)
        {
            IWebElement ParamCity = _driver.FindElement(By.XPath($".//*[@class='dropdown-menu dropdown-primary']//*[contains(text(),'{selector}')]"));
            ParamCity.Click();
        }

        //public void OpenTypeDeliveryDdl()
        //{
        //    IWebElement DeliveryDdl = _driver.FindElement(By.Id("slctshipmentType"));
        //    DeliveryDdl.Click();
            
        //}

        public void ChoiseWehouse()
        {
            IWebElement SelectCourierService = _driver.FindElement(By.Id("radioWar"));
            SelectCourierService.Click();

        }



        public void SelectCourierServiceInDdlDelivery()
        {
            IWebElement SelectCourierService = _driver.FindElement(By.XPath("//*[@id='slctshipmentType']//*[contains(text(),'Курьерская')]"));
            SelectCourierService.Click();
        }

        public void SelectPickupInDdlDelivery()
        {
            IWebElement SelectPickup = _driver.FindElement(By.XPath("(//div[@class='option selected'])[5]"));////*[@id='slctshipmentType']//*[contains(text(),'Самовывоз')]
            SelectPickup.Click();
        }

        public void SelectSchedukedDeliveryInDdlDelivery()
        {
            IWebElement SelectCourierService = _driver.FindElement(By.XPath("//*[@class='selectize-dropdown-content']//*[contains(text(),'Плановая')]")); //
            SelectCourierService.Click();
        }


        public void refreshJournal()
        {
            IWebElement ButtonRefreshJournal = _driver.FindElement(By.XPath("(//i[@class='fa fa-refresh'])[2]"));
            ButtonRefreshJournal.Click();
        }


        //public void ClickOnButtonReservationInvoiceInOrder()
        //{
        //    var basketTabInvoice = _driver.FindElement(By.XPath("//*[@id='openHeaderInvoice']"));
        //    var buttonReservationInvoice = basketTabInvoice.FindElement(By.Id("buttonBasketReservationInvoice"));
        //    buttonReservationInvoice.Click();

        //}





        public void WaitUntilElementToBeClickableAndClickOnThemID(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(40));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(selector)));
            element.Click();
        }

        public void InvoiceStatusInBasketTbl(string status)
        {
            IWebElement invoiceStatus = _driver.FindElement(By.XPath($"//*[@id='openHeaderInvoice']//*[contains(text(),{status})]"));
        }

        //public void ClickOnInvoicesJournalInBasket()
        //{
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(40));
        //    IWebElement InvoicesJournalInBasket = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("accountSecondTabUser")));

        //    InvoicesJournalInBasket.Click();
        //}


        public void SaveInvoice()
        {
            ButtonSaveInvoice.Click();
        }

        public void ClickOnButtonSaveInvoiceInOrder()
        {
            ButtonSaveInvoiceInOrder.Click();
        }

        public void ClickOnButtonReservationInvoiceInOrder()
        {
            ButtonReservationInvoiceInOrder.Click();
        }

        public void ClickShipmentTypeScheduled()
        {
            SelectShipmentTypeScheduled.Click();
        }

        public void ClickShipmentTypePickup()
        {
            SelectShipmentTypePickup.Click();
        }

        public void ReservationInvoice()
        {
            ButtonReservationInvoice.Click();
        }

        public void OpenDdlSlctshipmentType()
        {
            SlctshipmentTypeDdl.Click();
        }


        public void OpenBasket()
        {
            NavabarBasket.Click();
        }

        public void RemoveInvoiceFromBasket()
        {
            ButtonRemoveInvoiceFromBasket.Click();
        }

        public void ClearCart()
        {
            NavabarBasket.Click();
        }

        public void ClickOnInvoiceJournalTab()
        {
            InvoiceJournalTab.Click();
        }

        public void DeleteInvoiceSendYes()
        {
            var alertWnd = _driver.SwitchTo().Alert();
            alertWnd.Accept();
        }

        public void DeleteInvoiceSendNo()
        {
            var alertWnd = _driver.SwitchTo().Alert();
            alertWnd.Dismiss();
        }

        public void ClosePopupNotifications()
        {
            RemoveButtonInPopupNotification = _driver.FindElements(By.XPath("//*[@id='toast-container']/div/button"));
        }

        public void InputBasketAddPosition(string text)
        {
            /*hread.Sleep(1500);*/
            InputBasketAddCard.SendKeys(text);
            GoButton.Click();
        }

        public void ClickButtonRefreshShipmentDetails()
        {
            RefreshShipmentDetails.Click();
        }

        public void RemoveAllInvoicesInJournalBasket()
        {
            
            var removeInvoice = _driver.FindElements(By.CssSelector("tr button[id=buttonBasketRemoveInvoice]"));
            foreach (var item in removeInvoice)
            {
                item.Click();
                DeleteInvoiceSendYes();
                Thread.Sleep(1000);
            }

        }

        public void CloseAllPopupNotification()
        {
            ClosePopupNotifications();
            for (var i = 0; i < RemoveButtonInPopupNotification.Count; i++)
            {
                RemoveButtonInPopupNotification[i].Click();
            }
        }


        public void CloseAllPopupNotificationIfTheyShow()
        {
            ClosePopupNotifications();

            if (RemoveButtonInPopupNotification == null)
            {
                ClickOnInvoiceJournalTab();
            }
            else
            {
                CloseAllPopupNotification();
            }
        }
    }

}