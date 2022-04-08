//using NUnit.Framework;
//using OpenQA.Selenium;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class WheelRimTests : BaseTest
//    {
//        private WheelRimSelection rim;

//        //public WheelRimTests() : base()
//        //{
//        //    rim = new WheelRimSelection(_browser);
//        //}


//        //[OneTimeSetUp]
//        //public void LoadPage()
//        //{
//        //    LoginOnWebSite();
//        //    _browser.WaitForAngular();
//        //}


//        [SetUp]
//        public void OpenWheelRimSearch()
//        {
//            rim = new WheelRimSelection(_browser);
//            _browser.WaitForAngular();
//            rim.OpenDdlSelection();
//            NavigateCategoryTires("Колесные диски");

//            //while (!IsElementVisible(By.XPath("(//span[@class='text']//*[contains(text(),'12')])[1]")))
//            //{
//            //    {
//            //        rim.OpenSelectionTires();
//            //        rim.OpenCategoryWheelRimSelection();
//            //    }
//            //}
//        }

//        [Test]
//        public void WheelRimSearchWidthResultMustBeSuccess()
//        {

//            rim.SelectWidthParam("12");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("12"));

//        }

//        [Test]
//        public void WheelRimSearchDiametrsResultMustBeSuccess()
//        {
//            rim.SelectDiameterParam("17,5");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("17,5"));

//        }

//        [Test]
//        public void WheelRimSearchPCDResultMustBeSuccess()
//        {
//            rim.SelectDiscPCDParam("10х335");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Диск колесный"));

//        }

//        [Test]
//        public void WheelRimSearchETResultMustBeSuccess()
//        {
//            rim.SelectDiscETParam("106");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Диск колесный"));

//        }

//        [Test]
//        public void WheelRimSearchDIAResultMustBeSuccess()
//        {
//            rim.SelectDiscDIAParam("130");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Диск колесный"));

//        }

//        [Test]
//        public void WheelRimSearchColorResultMustBeSuccess()
//        {
//            rim.SelectDiscColorParam("Белый");
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Диск колесный"));

//        }


//        [Test]
//        public void WheelRimSearchHavePrices()
//        {
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            if (priceText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }


//        [Test]
//        public void WheelRimMustHaveRests()
//        {
//            rim.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }


//    }
//}

