//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class TiresTests : BaseTest
//    {
//        private TiresSelection tires;

//        //public TiresTests() : base()
//        //{
//        //    tires = new TiresSelection(_browser);
//        //}


//        //[OneTimeSetUp]
//        //public void LoadPage()
//        //{
//        //    LoginOnWebSite();
//        //    _browser.WaitForAngular();
//        //}




//        [SetUp]
//        public void OpenTiresSearch()
//        {
//            tires = new TiresSelection(_browser);
//            _browser.WaitForAngular();
//            tires.OpenDdlSelection();
//            NavigateCategoryTires("Шины");

//        }


//        [Test]
//        public void TiresSearchSizeResultMustBeSuccess()
//        {

//            tires.SelectParamTiresSize("/45");
//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("/45"));

//        }

//        [Test]
//        public void TiresSearchDiametrResultMustBeSuccess()
//        {

//            tires.SelectParamTiresDiametr("12");
//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Шина"));

//        }

//        [Test]
//        public void TiresSearchSeasonMustBeSucsess()
//        {
//            tires.SelectParamTiresSeason("Зима");

//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Шина"));
//        }


//        [Test]
//        public void TiresSearchAppointmentMustBeSuccess()
//        {
//            tires.SelectParamTiresAppointment("Легковая");

//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Шина"));


//        }

//        [Test]
//        public void TiresMustHavePrices()
//        {
//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            if (priceText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//            //var priceNumberStr = priceText.Replace(".", ",").Trim();
//            //double price;
//            //var isNumber = double.TryParse(priceNumberStr, out price);
//            //Assert.IsTrue(isNumber);
//        }

//        [Test]
//        public void TiresMustHaveRests()
//        {
//            tires.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }


//    }
//}
