using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
namespace ToolsQA.pages
{
    class AccumSelection
    {
        private IWebDriver _driver;
        private NgWebDriver _browser;

        public AccumSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryAccum")]
        [CacheLookup]
        private IWebElement ButtonCategoryAccum { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-lg btn-default catalog-btn']")]
        [CacheLookup]
        private IWebElement DropdownListSelection { get; set; }
        

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")] //(//*[contains(text(),'Применить')])[1]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        public void SelectParamAccumVoltage(string selector)
        {
            IWebElement AccumVoltage = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.voltageList']//*[contains(text(),'{selector}')])[1]"));
            AccumVoltage.Click();
        }
        public void SelectParamAccumCapacity(string selector)
        {
            IWebElement AccumCapacity = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.accumCapacityList']//*[contains(text(),'{selector}')])[1]"));
            AccumCapacity.Click();
        }
        public void SelectParamAccumStartingCurrent(string selector)
        {
            IWebElement AccumStartingCurrent = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.startAmperageList']//*[contains(text(),'{selector}')])[1]"));
            AccumStartingCurrent.Click();
        }
        public void SelectParamAccumLength(string selector)
        {
            IWebElement AccumLength = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.lengthList']//*[contains(text(),'{selector}')])[1]"));
            AccumLength.Click();
        }
        public void SelectParamAccumWidth(string selector)
        {
            IWebElement AccumWidth = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.accumWidthList']//*[contains(text(),'{selector}')])[1]"));
            AccumWidth.Click();
        }
        public void SelectParamAccumHeight(string selector)
        {
            IWebElement AccumHeight = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.heightList']//*[contains(text(),'{selector}')])[1]"));
            AccumHeight.Click();
        }
        public void SelectParamAccumLocationOfPolePins(string selector)
        {
            IWebElement AccumLocationOfPolePins = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.terminalPolarityList']//*[contains(text(),'{selector}')])[1]"));
            AccumLocationOfPolePins.Click();
        }
        public void SelectParamAccumTerminals(string selector)
        {
            IWebElement AccumTerminals = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.terminalsList']//*[contains(text(),'{selector}')])[1]"));
            AccumTerminals.Click();
        }
        public void SelectParamAccumBodyType(string selector)
        {
            IWebElement AccumBodyType = _driver.FindElement(By.XPath($"(.//div[@data='extended_model.caseTypeList']//*[contains(text(),'{selector}')])[1]"));
            AccumBodyType.Click();
        }


        public void OpenDdlSelection()
        {
            DropdownListSelection.Click();
        }

        public void OpenSelectionAccum()
        {
            if (ButtonCategoryAccum != null)
                ButtonCategoryAccum.Click();
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
