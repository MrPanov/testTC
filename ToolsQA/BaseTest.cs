using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using ToolsQA.pages;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace ToolsQA.TestsCases
{

    public class BaseTest
    {
        protected string Url = "https://my.omega.page/#/login";
        protected readonly IWebDriver _driver;
        protected readonly NgWebDriver _browser;
        

        public BaseTest()
        {

             _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.dll", ""));
            var opts = new ChromeOptions();
            opts.PlatformName = "Windows";
            //_driver = new RemoteWebDriver(new Uri("http://10.0.30.70:5555/wd/hub"), opts.ToCapabilities(), TimeSpan.FromMinutes(3));
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _browser = new NgWebDriver(_driver);
            _browser.Manage().Window.Maximize();
            _browser.Url = Url; /*+ "/login"*/
            WaitForElementToBeClickableID("loginInputEmail"); 
        }       
              



        public void WaitForElementIsVisibleID(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector)));
        }

        public void WaitForLinkTextIsVisible(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(selector)));
        }

        public void WaitForElementIsVisibleCSS(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
        }

        public void WaitForElementIsVisibleXpath(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(selector)));
        }

        public void WaitForElementToBeClickableID(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(selector)));
        }

        public void WaitForElementToBeClickableCSS(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(selector)));
        }

        public void WaitForElementToBeClickableXpath(string selector)
        {
            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(selector)));
        }


        public void NavigateCategoryTires (string selector)
            {
            Actions action = new Actions(_driver);
            IWebElement sidebarCategory = _driver.FindElement(By.Id("sidebarCategoryTires"));
            action.MoveToElement(sidebarCategory).MoveToElement(_driver.FindElement(By.XPath($"(//span[@class='menu-text']//*[contains(text(),'{selector}')])"))).Click().Build().Perform();
            }

        public void NavigateCategoryOil(string selector)
        {
            Actions action = new Actions(_driver);
            IWebElement sidebarCategory = _driver.FindElement(By.Id("sidebarCategoryOil"));
            action.MoveToElement(sidebarCategory).MoveToElement(_driver.FindElement(By.XPath($"((//span[@class='menu-text']//*[contains(text(),'{selector}')]))[2]"))).Click().Build().Perform();
        }


        //public void OpenDeashbordPage()
        //{
        //    var dashboard = new DashboardPage(_browser);
        //}

        public void ScrollUp()
        {
            IJavaScriptExecutor jsS = (IJavaScriptExecutor)_driver;
            var js = String.Format("window.scrollTo({0}, {1})", 0, 0);
            jsS.ExecuteScript(js);
            Thread.Sleep(2000);

        }


        [OneTimeSetUp]
        public void LoginOnWebSite()
        {            
            var loginPage = new LoginPage(_browser);            
            loginPage.LoginToApplication();
            _browser.WaitForAngular();
            //WaitForElementIsVisibleXpath("//a[@class='btn btn - default dropdown- toggle']");            
            
        }

        

        [OneTimeTearDown]
        public void RunAfterClassTestsQuitBrowser()
        {
            _browser.Quit();
            _driver.Quit();
        }
    }
}
