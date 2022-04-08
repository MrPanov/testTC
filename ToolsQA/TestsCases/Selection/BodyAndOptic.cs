//using NUnit.Framework;
//using OpenQA.Selenium;
//using System.Threading;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{

//    [TestFixture]
//    class BodyAndOpticTests : BaseTest
//    {
//        private BodyAndOpticSelection bodyAndOptic;




//        [SetUp]
//        public void OpenBodyAndOpticSearch()
//        {
//            bodyAndOptic = new BodyAndOpticSelection(_browser);
//            _browser.WaitForAngular();

//            bodyAndOptic.OpenDdlSelection();
//            bodyAndOptic.OpenSidebarCategoryOptic();


//            //while (!IsElementVisible(By.XPath("(//div[@data='extended_model.opticGroupList']//*[contains(text(),'Зеркала')])[1]")))
//            //{
//            //    bodyAndOptic.OpenSelectionBodyAndOptic();
//            //}


//        }

//        [Test]

//        public void BodyAndOpticGroupSearchResultMustBeSuccess()
//        {
//            bodyAndOptic.SelectParamBodyAndOpticSelectionGroup("Зеркала");
//            bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.XPath(".//*[@class='searchDescrip']//*[contains(text(),'ЗЕРК')]")).Text.Contains("ЗЕРК"));


//        }

//        [Test]

//        public void BodyAndOpticSideSearchResultMustBeSuccess()
//        {
//            bodyAndOptic.SelectParamBodyAndOpticSelectionSide("право");
//            bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            Assert.IsTrue(_driver.FindElement(By.XPath(".//*[@class='searchDescrip']//*[contains(text(),'ПРА')]")).Text.Contains("ПРА"));

//        }

//        [Test]
//        public void BodyAndOpticsMustHavePrices()
//        {


//            bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            //var priceText = _browser.FindElement(By.XPath("(//span[@class='price-nowrap'])[1]")).Text;
//            //var priceNumberStr = priceText.Replace("грн.", "").Replace(".", ",");
//            //double price;
//            //var isNumber = double.TryParse(priceNumberStr, out price);
//            //Assert.IsTrue(isNumber);
//            var priceText = _browser.FindElement(By.XPath("(//div[@class='searchOwnPrice'])[1]")).Text;
//            if (priceText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }

//        }

//        [Test]
//        public void BodyAndOpticsMustHaveRests()
//        {
//            bodyAndOptic.ClickOnButtonApplyInAdvancedSearch();
//            WaitForElementIsVisibleXpath("//table[@class='table table-available table-bordered']");
//            var restsText = _browser.FindElement(By.CssSelector(".hidden-sm.hidden-xs")).Text;

//            if (restsText.Trim().Contains("-"))
//            {
//                Assert.Fail();
//            }

//        }


//        //public void HideAdvancedSearch()
//        //{

//        //    bodyAndOptic.OpenSelectionBodyAndOptic();
//        //    bodyAndOptic.ChatbarHide();
//        //}

//        //[TearDown]
//        //public void ClearSearchParametrs()
//        //{
//        //    _browser.WaitForAngular();
//        //    var removeLables = _browser.FindElements(By.CssSelector("li:nth-child(1) > span"));
//        //    for (var i = 0; i < removeLables.Count; i++)
//        //    {
//        //        removeLables[i].Click();
//        //    }

//        //}

//    }
//}

