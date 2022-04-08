using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.pages;

namespace ToolsQA.TestsCases
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        private DashboardPage dashboard;

        
        [SetUp]
        public void SearchTests()
        {
            dashboard = new DashboardPage(_browser);
            _browser.WaitForAngular();
        }
               
        [TearDown]
        public void ClearSearchFildAfterTests()
        {
            dashboard.ClearSearchFildAfterTests();
        }


        [Test]
        public void VinSearchMustBeSuccess()
        {


            dashboard.EnableSearch("1B3acn6b78n276130");
            WaitForElementIsVisibleXpath("(//tbody[@ng-repeat='vehicle in carByVin'])[1]");
            var carByVin = _driver.FindElement(By.XPath("(//tbody[@ng-repeat='vehicle in carByVin'])[1]"));
            Assert.IsTrue(carByVin.Displayed);
        }

        //[Test]
        //public void SearchOpenAnalogs()
        //{

        //    //WaitForElementID("headerInputSearch");
        //    //dashboard.EnableSearch("6900260289");
        //    //WaitForElementID("addBasket");
        //    //dashboard.LoadMoreAnalog();
        //    //var priceText = _browser.FindElement(By.CssSelector("td:nth-child(8) > span")).Text;
        //    //double number = 0;

        //    //Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
        //    //Assert.Greater(number, 0);

        //}

        [Test]
        public void SimpleSearchNAmeMustBeSuccess()
        {


            dashboard.EnableSearch("Фильтр масляный");
            WaitForElementIsVisibleID("addBasket");
            var priceText = _browser.FindElement(By.CssSelector(".searchOwnPrice > span:nth-child(2)")).Text;
            double number = 0;
            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }


        [Test]
        public void SimpleSearchCodMustBeSuccess()
        {
            dashboard.EnableSearch("46101131770");
            WaitForElementIsVisibleID("addBasket");
            var priceText = _browser.FindElement(By.CssSelector(".price-nowrap > span:nth-child(1)")).Text;
            double number = 0;

            Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
            Assert.Greater(number, 0);
        }

        //[Test]
        //public void SimpleSearchChangeSarchToLineCodMustBeSuccess()
        //{
        //    dashboard.EnableSearch("1020988-1");
        //    WaitForElementIsVisibleID("addBasket");

        //    var priceText = _browser.FindElement(By.CssSelector(".searchOwnPrice > span:nth-child(2)")).Text;
        //    double number = 0;

        //    Assert.DoesNotThrow(() => number = double.Parse(priceText.Replace(".", ",")));
        //    Assert.Greater(number, 0);
        //}


    }
}
