using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages
{
    class LampsSelection
    {
        private IWebDriver _driver;

        public LampsSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryLamps")]
        [CacheLookup]
        private IWebElement ButtonCategoryLamps { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }





        public void SelectParamLampsPower(string selector)
        {            
            IWebElement ParamLampsPower = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.lampPowerList']//*[contains(text(),'{selector}')])[1]"));
            ParamLampsPower.Click();
        }

    
        public void SelectParamLampsBase(string selector)
        {
            IWebElement ParamLampsBase = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.lampBaseList']//*[contains(text(),'{selector}')])[1]"));
            ParamLampsBase.Click();
        }
        public void SelectParamLampsVoltage(string selector)
        {
            IWebElement ParamLampsVoltage = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.lampVoltageList']//*[contains(text(),'{selector}')])[1]"));
            ParamLampsVoltage.Click();
        }
        public void SelectParamLampsXenon(string selector)
        {
            IWebElement ParamLampsXenon = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.xenonList']//*[contains(text(),'{selector}')])[1]"));
            ParamLampsXenon.Click();
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-lg btn-default catalog-btn']")]
        [CacheLookup]
        private IWebElement DropdownListSelection { get; set; }

        public void OpenDdlSelection()
        {
            DropdownListSelection.Click();
        }



        public void OpenSelectionLamps()
        {
            
                ButtonCategoryLamps.Click();
        }

        

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            
                ButtonEnterAdvancedSearch.Click();
        }

        
       

        public void HideChatbarIfTheyOpen()
        {
            if (CategoryFilter.Displayed)
            {
                HeaderMainFilter.Click();
            }
        }
    }
    
}