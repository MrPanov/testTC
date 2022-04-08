using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages

{
    class OilSelection

    {
        private IWebDriver _driver;

        public OilSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOil")]
        [CacheLookup]
        private IWebElement ButtonCategoryOil { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='sidebarCategoryOil']/span/translate/span)[2]")] 
        [CacheLookup]
        private IWebElement ButtonCategoryOilSelection { get; set; }



        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }



        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }

        public void SelectParamOilAppointment(string selector)
        {            
            IWebElement OilAppointment = _driver.FindElement(By.XPath($"(//div[@data='extended_model.purposeList']//*[contains(text(),'{selector}')])[1]"));
            OilAppointment.Click();
        }

        public void SelectParamOilViscosity(string selector)
        {
            IWebElement OilViscosity = _driver.FindElement(By.XPath($"(//div[@data='extended_model.viscosityList']//*[contains(text(),'{selector}')])[1]"));
            OilViscosity.Click();
        }
        public void SelectParamOilVolume(string selector)
        {
            IWebElement OilVolume = _driver.FindElement(By.XPath($"(//div[@data='extended_model.scopeList']//*[contains(text(),'{selector}')])[1]"));
            OilVolume.Click();
        }
        public void SelectParamOilApplicability(string selector)
        {
            IWebElement OilApplicability = _driver.FindElement(By.XPath($"(//div[@data='extended_model.applicabilityList']//*[contains(text(),'{selector}')])[1]"));
            OilApplicability.Click();
        }
        public void SelectParamOilType(string selector)
        {
            IWebElement OilType = _driver.FindElement(By.XPath($"(//div[@data='extended_model.typeList']//*[contains(text(),'{selector}')])[1]"));
            OilType.Click();
        }
        public void SelectParamOilAPISpecifications(string selector)
        {
            IWebElement OilAPISpecifications = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specAPIList']//*[contains(text(),'{selector}')])[1]"));
            OilAPISpecifications.Click();
        }
        public void SelectParamOilACEASpecifications(string selector)
        {
            IWebElement OilACEASpecifications = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specACEAList']//*[contains(text(),'{selector}')])[1]"));
            OilACEASpecifications.Click();
        }
        public void SelectParamOilLSACSpecifications(string selector)
        {
            IWebElement OilLSACSpecifications = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specLSACList']//*[contains(text(),'{selector}')])[1]"));
            OilLSACSpecifications.Click();
        }
        public void SelectParamOilJASOSpecifications(string selector)
        {
            IWebElement OilJASOSpecifications = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specJASOList']//*[contains(text(),'{selector}')])[1]"));
            OilJASOSpecifications.Click();
        }
        public void SelectParamOilOEMSpecifications(string selector)
        {
            IWebElement OilOEMSpecifications = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specOEMList']//*[contains(text(),'{selector}')])[1]"));
            OilOEMSpecifications.Click();
        }
        public void SelectParamOilGOST(string selector)
        {
            IWebElement OilGOST = _driver.FindElement(By.XPath($"(//div[@data='extended_model.ISOList']//*[contains(text(),'{selector}')])[1]"));
            OilGOST.Click();
        }

        public void HideChatbarIfTheyOpen()
        {
            if (CategoryFilter.Displayed)
            {
                HeaderMainFilter.Click();
            }
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-lg btn-default catalog-btn']")]
        [CacheLookup]
        private IWebElement DropdownListSelection { get; set; }

        public void OpenDdlSelection()
        {
            DropdownListSelection.Click();
        }

        public void OpenSelectionOil()
        {
            if (ButtonCategoryOil != null)
                ButtonCategoryOil.Click();
        }

        public void OpenCategoryOilSelection()
        {
            if (ButtonCategoryOilSelection != null)
                ButtonCategoryOilSelection.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            
                ButtonEnterAdvancedSearch.Click();
        }
       

      
    }
}
