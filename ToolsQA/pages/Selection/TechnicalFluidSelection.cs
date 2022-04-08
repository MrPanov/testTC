using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace ToolsQA.pages
{
    class TechnicalFluidSelection
    {
        private IWebDriver _driver;

        public TechnicalFluidSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOil")]
        [CacheLookup]
        private IWebElement ButtonCategoryOil { get; set; }

        [FindsBy(How = How.Id, Using = "sidebarCategoryTechnicalFluid")]
        [CacheLookup]
        private IWebElement ButtonCategoryTechnicalFluid { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }


        public void SelectParamTechnicalFluidsAppointment(string selector)
        {
            IWebElement FluidsAppointment = _driver.FindElement(By.XPath($"(//div[@data='extended_model.purposeTFList']//*[contains(text(),'{selector}')])[1]"));
            FluidsAppointment.Click();
        }
        public void SelectParamTechnicalFluidsColour(string selector)
        {
            IWebElement FluidsColour = _driver.FindElement(By.XPath($"(//div[@data='extended_model.colorTFList']//*[contains(text(),'{selector}')])[1]"));
            FluidsColour.Click();
        }
        public void SelectParamTechnicalFluidsSeasons(string selector)
        {
            IWebElement FluidsSeasons  = _driver.FindElement(By.XPath($"(//div[@data='extended_model.seasonalityTFList']//*[contains(text(),'{selector}')])[1]"));
            FluidsSeasons.Click();
        }
        public void SelectParamTechnicalFluidsOEMSpecifications(string selector)
        {
            IWebElement FluidsOEMSpecifications  = _driver.FindElement(By.XPath($"(//div[@data='extended_model.specOEMTFList']//*[contains(text(),'{selector}')])[1]"));
            FluidsOEMSpecifications.Click();
        }
        public void SelectParamTechnicalFluidsVolume(string selector)
        {
            IWebElement FluidsVolume = _driver.FindElement(By.XPath($"(//div[@data='extended_model.scopeTFList']//*[contains(text(),'{selector}')])[1]"));
            FluidsVolume.Click();
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


        public void OpenSelectionOIL()
        {
            if (ButtonCategoryOil != null)
                ButtonCategoryOil.Click();
        }

        public void OpenSelectionTechnicalFluid()
        {
            if (ButtonCategoryTechnicalFluid != null)
                ButtonCategoryTechnicalFluid.Click();
        }

        public void ClickOnButtonApplyInAdvancedSearch()
        {

            ButtonEnterAdvancedSearch.Click();
        }

       
    }
}

