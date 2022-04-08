using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;

namespace ToolsQA.pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private NgWebDriver _browser;

        [FindsBy(How = How.Id, Using = "loginInputEmail")]
        [CacheLookup]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "loginInputPassword")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "buttonLogin")]
        [CacheLookup]
        private IWebElement Submit { get; set; }

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication()
        {
            UserName.SendKeys("web@omega-auto.biz");
            Password.SendKeys("qwerty1");
            Submit.Click();
            
            

            
        }

        public void LoginToApplicationForClaimes()
        {
            UserName.SendKeys("Панов Максим");
            Password.SendKeys("aere7bvf");
            Submit.Click();
        }
    }
}