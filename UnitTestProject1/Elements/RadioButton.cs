using OpenQA.Selenium;
using UnitTestProject;

namespace UnitTestProject1.Elements
{
    class RadioButton : BasePage
    {
        public enum id
        {
            paragraphs,
            words,
            bytes,
            listes
        }

        public RadioButton(IWebDriver driver) : base(driver)
         {
           
         }
       
        public IWebElement CreateRadioButton(string id)
        {           
            IWebElement webElement = _driver.FindElement(By.XPath($"//label[contains(@for, '{id}')]"));
            return webElement;
        }
    }
}
