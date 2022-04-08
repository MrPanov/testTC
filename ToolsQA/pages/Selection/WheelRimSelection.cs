using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;

namespace ToolsQA.pages
{
    class WheelRimSelection
    {
        private IWebDriver _driver;
        private NgWebDriver _browser;

        public WheelRimSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryTires")]
        [CacheLookup]
        private IWebElement SidebarCategoryTires { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='Capa_1'])[3]")]
        [CacheLookup]
        private IWebElement CategorySelectionWheelRim { get; set; }

        [FindsBy(How = How.Id, Using = "navbarIconFilter")]
        [CacheLookup]
        private IWebElement NavbarIconFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }



        public void SelectWidthParam(string Param)
        {
            IWebElement WidthParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelWidthList']//*[contains(text(),'{Param}')])[1]"));
            WidthParam.Click();
        }

        public void SelectDiameterParam(string Param)
        {
            IWebElement DiameterParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelDiameterList']//*[contains(text(),'{Param}')])[1]"));
            DiameterParam.Click();
        }

        public void SelectDiscPCDParam(string Param)
        {
            IWebElement PCDParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelPCDList']//*[contains(text(),'{Param}')])[1]"));
            PCDParam.Click();
        }

        public void SelectDiscETParam(string Param)
        {
            IWebElement ETLParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelETList']//*[contains(text(),'{Param}')])[1]"));
            ETLParam.Click();
        }

        public void SelectDiscDIAParam(string Param)
        {
            IWebElement DIAParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelDIAList']//*[contains(text(),'{Param}')])[1]"));
            DIAParam.Click();
        }

        public void SelectDiscColorParam(string Param)
        {
            IWebElement ColorParam = _driver.FindElement(By.XPath($"(//div[@data='extended_model.wheelColorList']//*[contains(text(),'{Param}')])[1]"));
            ColorParam.Click();
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-lg btn-default catalog-btn']")]
        [CacheLookup]
        private IWebElement DropdownListSelection { get; set; }

        public void OpenDdlSelection()
        {
            DropdownListSelection.Click();
        }




        public void OpenSidebarCategoryTires()
        {
            if (SidebarCategoryTires != null)
                SidebarCategoryTires.Click();
        }

        public void OpenCategoryWheelRimSelection()
        {
            if (CategorySelectionWheelRim != null)
                CategorySelectionWheelRim.Click();
        }

        public void AdvancedSearchClick()
        {
            if (NavbarIconFilter != null)
                NavbarIconFilter.Click();
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
