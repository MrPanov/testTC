using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ToolsQA.pages
{
    class BodyAndOpticSelection
    {
        private IWebDriver _driver;

        public BodyAndOpticSelection (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "sidebarCategoryOptic")]
        [CacheLookup]
        private IWebElement SidebarCategoryOptic { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-lightgreen btn-lg']")]
        [CacheLookup]
        private IWebElement ButtonEnterAdvancedSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "category-filter")]
        [CacheLookup]
        private IWebElement CategoryFilter { get; set; }


        [FindsBy(How = How.ClassName, Using = "header-main-filter")]
        [CacheLookup]
        private IWebElement HeaderMainFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-lg btn-default catalog-btn']")]
        [CacheLookup]
        private IWebElement DropdownListSelection { get; set; }

        public void OpenDdlSelection()
        {
            DropdownListSelection.Click();
        }





        public void SelectParamBodyAndOpticSelectionGroup(string selector)
        {
            IWebElement BodyAndOpticSelectionGroup = _driver.FindElement(By.XPath($"(//div[@data='extended_model.opticGroupList']//*[contains(text(),'{selector}')])[1]"));
            BodyAndOpticSelectionGroup.Click();
        }
        public void SelectParamBodyAndOpticSelectionSide(string selector)
        {
            IWebElement BodyAndOpticSelectionSide = _driver.FindElement(By.XPath($"(//div[@data='extended_model.opticNbodySideList']//*[contains(text(),'{selector}')])[1]"));
            BodyAndOpticSelectionSide.Click();
        }

        public void OpenSidebarCategoryOptic()
        {
            if (SidebarCategoryOptic != null)
                SidebarCategoryOptic.Click();
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
