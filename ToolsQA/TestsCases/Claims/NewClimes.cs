//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;
//using Protractor;
//using System;
//using ToolsQA.pages;
//using OpenQA.Selenium.Interactions;
//using System.Threading;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using ToolsQA.pages;

//namespace ToolsQA.TestsCases
//{
//    public class NewClimes
//    {
//        protected string Url = "http://new.omega-auto.biz/#";
//        protected readonly IWebDriver _driver;
//        protected readonly NgWebDriver _browser;

//        public NewClimes()
//        {
//            _driver = new ChromeDriver(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("ToolsQA.dll", ""));
//            var opts = new ChromeOptions();
//            opts.PlatformName = "Windows";
//            //_driver = new RemoteWebDriver(new Uri("http://192.168.100.32:5556/wd/hub"), opts.ToCapabilities(), TimeSpan.FromMinutes(1));
//            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60);
//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
//            _driver.Manage().Window.Maximize();
//            _browser = new NgWebDriver(_driver);
//            _browser.Manage().Window.Maximize();
//            _browser.Url = Url + "/login";

//        }

//        public void WaitForElementIsVisibleID(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(selector)));
//        }

//        public void WaitForElementIsVisibleCSS(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
//        }

//        public void WaitForElementIsVisibleXpath(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(selector)));
//        }

//        public void WaitForElementToBeClickableID(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(selector)));
//        }

//        public void WaitForElementToBeClickableCSS(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(selector)));
//        }

//        public void WaitForElementToBeClickableXpath(string selector)
//        {
//            WebDriverWait wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(60));
//            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(selector)));
//        }


//        //public void OpenDeashbordPage()
//        //{
//        //    var dashboard = new DashboardPage(_browser);
//        //}

//        [OneTimeSetUp]
//        public void RunBeforeAllTestLogin()
//        {
//            var loginPage = new LoginPage(_browser);
//            WaitForElementIsVisibleID("loginInputEmail");
//            loginPage.LoginToApplicationForClaimes();
//            _browser.WaitForAngular();
//            //_browser.Navigate().GoToUrl("https://new.omega-auto.biz/#/app/claimsList/");
//        }



//        [OneTimeTearDown]
//        public void RunAfterClassTestsQuitBrowser()
//        {

//            _browser.Quit();
//            _driver.Quit();
//        }

//        [Test]
//        public void CreateClames()
//        {
//            _driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[1]/div[4]/div[3]/label/span")).Click();
//            _driver.FindElement(By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div > div.navbar-inner > div.navbar-container.clearfix > div:nth-child(4) > div:nth-child(1) > div > div > div > input.form-control.ui-select-search.ng-valid.ng-dirty.ng-valid-parse.ng-touched")).Click();
//            _driver.FindElement(By.CssSelector("body > div:nth-child(2) > div:nth-child(2) > div > div.navbar-inner > div.navbar-container.clearfix > div:nth-child(4) > div:nth-child(1) > div > div > div > input.form-control.ui-select-search.ng-valid.ng-dirty.ng-valid-parse.ng-touched")).SendKeys("Рева Наталя");
//            _driver.FindElement(By.XPath("//*[@id='ui - select - choices - row - 1 - 0']/a")).Click();
//        }
//    }



    
//}
