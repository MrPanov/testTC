//using NUnit.Framework;
//using OpenQA.Selenium;
//using System;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class OilTests : BaseTest
//    {
//        private OilSelection oil;


//        //public  OilTests() : base()
//        //{

//        //    oil = new OilSelection(_browser);
//        //}


//        //[OneTimeSetUp]
//        //public void LoadPage()
//        //{
//        //    LoginOnWebSite();
//        //    _browser.WaitForAngular();
//        //}


//        [SetUp]
//        public void OpenOilSearch()
//        {
//            oil = new OilSelection(_browser);
//            _browser.WaitForAngular();
//            oil.OpenDdlSelection();
//            NavigateCategoryOil("Масла");




//        }

//        [Test]
//        public void OilPurposeResultMustBeSuccess()
//        {
//            oil.SelectParamOilAppointment("Моторное масло");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }

//        [Test]
//        public void OilViscosityResultMustBeSuccess()
//        {

//            oil.SelectParamOilViscosity("10W-40");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }



//        [Test]
//        public void OilApplicabilityResultMustBeSuccess()
//        {
//            oil.SelectParamOilApplicability("Гидросистема");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Жидкость"));

//        }

//        [Test]
//        public void OilTypeResultMustBeSuccess()
//        {
//            oil.SelectParamOilType("Синтетическое");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }


//        [Test]
//        public void OilAPISpecificationsResultMustBeSuccess()
//        {
//            oil.SelectParamOilAPISpecifications("CC");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("CC"));

//        }

//        [Test]
//        public void OilACEASpecificationsResultMustBeSuccess()
//        {
//            oil.SelectParamOilACEASpecifications("A1/B1");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }

//        [Test]
//        public void OilLSACSpecificationsResultMustBeSuccess()
//        {
//            oil.SelectParamOilLSACSpecifications("GF-4");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло моторн"));

//        }

//        [Test]
//        public void OilJASOSpecificationsResultMustBeSuccess()
//        {
//            oil.SelectParamOilJASOSpecifications("DH-1");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло моторн"));

//        }

//        [Test]
//        public void OilOEMSpecificationsResultMustBeSuccess()
//        {
//            oil.SelectParamOilOEMSpecifications("Allison C-4");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }

//        [Test]
//        public void OilVolumetResultMustBeSuccess()
//        {
//            oil.SelectParamOilVolume("10");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло"));

//        }

//        [Test]
//        public void OilGOSTResultMustBeSuccess()
//        {
//            oil.SelectParamOilGOST("М-10Г2к");
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Масло моторн"));
//        }

//        [Test]
//        public void OilMustHavePrices()
//        {
//            oil.ClickOnButtonApplyInAdvancedSearch();

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
//            //WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']//span[contains(text(),'КВ')]");
//            //Assert.IsTrue(isNumber);

//        }

//        [Test]
//        public void OilMustHaveRests()
//        {
//            oil.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }

//        }


//    }

//}
