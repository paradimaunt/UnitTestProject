using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnitTestProject
{
    public class BasePage
    {
       
        public IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;                
            PageFactory.InitElements(_driver, this);
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }
    }
}
