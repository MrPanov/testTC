//using NUnit.Framework;
//using OpenQA.Selenium;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class LampTests : BaseTest
//    {
//        private LampsSelection lamp;



//        [SetUp]
//        public void OpenLampsSearch()
//        {
//            lamp = new LampsSelection(_browser);
//            _browser.WaitForAngular();
//            lamp.OpenDdlSelection();
//            lamp.OpenSelectionLamps();
//            _browser.WaitForAngular();

//        }

//        [Test]

//        public void LampsPowerSearchResultMustBeSuccess()
//        {
//            WaitForElementToBeClickableID("radioAllCar");
//            _driver.FindElement(By.Id("radioAllCar")).Click();
//            lamp.SelectParamLampsPower("0.4");
//            lamp.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Лампа"));

//        }

//        //[Test]

//        //public void LampsBaseSearchResultMustBeSuccess()
//        //{

//        //    lamp.SelectParamLampsBase("880");
//        //    lamp.ClickOnButtonApplyInAdvancedSearch();
//        //    WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//        //    Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Лампа"));
//        //}

//        [Test]

//        public void LampsVoltageSearchResultMustBeSuccess()
//        {

//            lamp.SelectParamLampsVoltage("12");
//            lamp.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("12"));
//        }

//        [Test]

//        public void LampsXenonSearchResultMustBeSuccess()
//        {

//            lamp.SelectParamLampsXenon("D2R");
//            lamp.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("D2R"));
//        }

//        [Test]
//        public void LampsMustHavePrices()
//        {

//            lamp.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            if (priceText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//            //var priceText = _browser.FindElement(By.XPath("(//span[@class='price-nowrap'])[1]")).Text;
//            //var priceNumberStr = priceText.Replace("грн.", "").Replace(".", ",");
//            //double price;
//            //var isNumber = double.TryParse(priceNumberStr, out price);
//            //Assert.IsTrue(isNumber);
//        }

//        [Test]
//        public void LampsMustHaveRests()
//        {
//            lamp.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }

//        }
//    }
//}
