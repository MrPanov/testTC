using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ToolsQA.pages
{
    class TiresSelection
    {
        private IWebDriver _driver;

        public TiresSelection(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryTires")]
        [CacheLookup]
        private IWebElement SidebarCategoryTires { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[@id='Capa_1'])[2]")]
        [CacheLookup]
        private IWebElement CategorySelectionTires { get; set; }



        public void SelectParamTiresDiametr(string selector)
        {
            IWebElement TiresDiametr = _driver.FindElement(By.XPath($"(//div[@data='extended_model.diameterList']//*[contains(text(),'{selector}')])[1]")); 
            TiresDiametr.Click();
        }

        public void SelectParamTiresSize(string selector)
        {
            IWebElement TiresSize = _driver.FindElement(By.XPath($"(//div[@data='extended_model.frameSizeList']//*[contains(text(),'{selector}')])[1]"));
            TiresSize.Click();
        }

        public void SelectParamTiresSeason(string selector)
        {
            IWebElement TiresSeason = _driver.FindElement(By.XPath($"(//div[@data='extended_model.seasonList']//*[contains(text(),'{selector}')])[1]"));
            TiresSeason.Click();
        }

        public void SelectParamTiresAppointment(string selector)
        {
            IWebElement TiresAppointment = _driver.FindElement(By.XPath($"(//div[@data='extended_model.usageList']//*[contains(text(),'{selector}')])[1]"));
            TiresAppointment.Click();
        }

        public void CloseFilterIconWithParametre()
        {
            IWebElement FilterIconWithParametre = _driver.FindElement(By.XPath("//span[@class='filter-icon']//span[@class='fa fa-remove']"));
            FilterIconWithParametre.Click();
        }

        [FindsBy(How = How.Id, Using = "navbarIconFilter")]
        [CacheLookup]
        private IWebElement NavbarIconFilter { get; set; }


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
               
       

        public void ClickOnButtonApplyInAdvancedSearch()
        {
            
                ButtonEnterAdvancedSearch.Click();
        }

       

        public void OpenCategoryTiresSelection()
        {
            if (CategorySelectionTires != null)
                CategorySelectionTires.Click();
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
