//using NUnit.Framework;
//using OpenQA.Selenium;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    [TestFixture]
//    class TechnicalFluidTests : BaseTest
//    {
//        private TechnicalFluidSelection technicalFluid;

         


//        [SetUp]
//        public void OpenAccumTechnicalFluidSearch()
//        {
//            technicalFluid = new TechnicalFluidSelection(_browser);
//            _browser.WaitForAngular();
//            technicalFluid.OpenDdlSelection();
//            NavigateCategoryOil("ТЖ");


//        }

//        [Test]
//        public void TechnicalFluidsAppointmentResultMustBeSuccess()
//        {


//            technicalFluid.SelectParamTechnicalFluidsAppointment("Жидкость тормозная");
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Жидкость торм"));

//        }

//        [Test]
//        public void TechnicalFluidsColorResultMustBeSuccess()
//        {
//            technicalFluid.SelectParamTechnicalFluidsColour("Зеленый");
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("зел"));


//        }

//        [Test]
//        public void TechnicalFluidsSeasonResultMustBeSuccess()
//        {
//            technicalFluid.SelectParamTechnicalFluidsSeasons("Зимний");
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("зим"));
//        }



//        [Test]
//        public void TechnicalFluidsOEMSpecificationsMustBeSuccess()
//        {
//            technicalFluid.SelectParamTechnicalFluidsOEMSpecifications("G12");
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Антифриз"));
//        }

//        [Test]
//        public void TechnicalFluidsVolumeResultMustBeSuccess()
//        {
//            technicalFluid.SelectParamTechnicalFluidsVolume("0,1");
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.ClassName("searchDescrip")).Text.Contains("Смазка"));

//        }

//        [Test]
//        public void TechnicalFluidsMustHavePrices()
//        {
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            var priceNumberStr = priceText.Replace("грн.", "").Replace(".", ",");
//            double price;
//            var isNumber = double.TryParse(priceNumberStr, out price);
//            Assert.IsTrue(isNumber);

//            //WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            //var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            //if (restsText.Trim().Contains("-"))
//            //{
//            //    Assert.Fail();
//            //}

//        }

//        [Test]
//        public void TechnicalFluidsMustHaveRests()
//        {
//            technicalFluid.ClickOnButtonApplyInAdvancedSearch();

//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;
//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }
//        }
//    }
//}
