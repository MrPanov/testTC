//using NUnit.Framework;
//using OpenQA.Selenium;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class AccumVoltagTests : BaseTest
//    {

//        private AccumSelection accum;


//        [SetUp]
//        public void OpenAccumSearch()
//        {
//            accum = new AccumSelection(_browser);
//            _browser.WaitForAngular();

//            //WaitForElementToBeClickableXpath("//a[@class='btn btn - default dropdown- toggle']");
//            accum.OpenDdlSelection();
//            accum.OpenSelectionAccum();
//        }






//        [Test]

//        public void AccumVoltageSearchResultMustBeSuccess()
//        {

//            accum.SelectParamAccumVoltage("6 В");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("6v"));
//        }

//        [Test]

//        public void AccumCapacitySearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumCapacity("5 А/ч");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("5Ah"));

//        }

//        [Test]

//        public void AccumStartingCurrentSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumStartingCurrent("50 А");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("50"));
//        }

//        [Test]

//        public void AccumLengthSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumLength("121 мм");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("121"));
//        }


//        [Test]
//        public void AccumHeightSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumHeight("104 мм");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Аккумулятор"));
//        }

//        [Test]
//        public void AccumLocationOfPolePinsSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumLocationOfPolePins("L");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Аккумулятор"));
//        }

//        [Test]
//        public void AccumTerminalSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumTerminals("1+19");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("278x175x190"));
//        }

//        [Test]
//        public void AccumBodyTypeSearchResultMustBeSuccess()
//        {
//            accum.SelectParamAccumBodyType("Азия");
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");

//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Аккумулятор"));
//        }

//        [Test]
//        public void AccumMustHavePrices()
//        {
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            if (priceText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }

//        [Test]
//        public void AccumMustHaveRests()
//        {
//            accum.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".searchOwnPrice > span:nth-child(2)")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }


//        }


//    }
//}