using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnitTestProject1.Elements;

namespace UnitTestProject.PageObject
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'amount')]")]
        private IWebElement inputFieldnumbers { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'generate')]")]
        private IWebElement symbolsGenerationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'ru')]")]
        private IWebElement changeLanguageToRussianButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'start')]")]
        private IWebElement startWithLoremIpsumButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@id='Panes']//p[contains(text(), 'это текст')]")]
        private IWebElement findTextInAParagraph { get; set; }

        public void ClickWordsButton()
        {
            new RadioButton(_driver).CreateRadioButton(RadioButton.id.words.ToString()).Click();
        }

        public void ClickBytesButton()
        {
            new RadioButton(_driver).CreateRadioButton(RadioButton.id.bytes.ToString()).Click();
        }

        public void ClickSymbolsGeneration()
        {
            symbolsGenerationButton.Click();
        }

        public void ClickChangeLanguageToRussianButton()
        {
            changeLanguageToRussianButton.Click();
        }

        public string CheckingThePresenceOfAWordInAParagraph()
        {
            return findTextInAParagraph.Text;
        }
       
        public void ClickStartWithLoremIpsum()
        {
            startWithLoremIpsumButton.Click();
        }
             
        public void SearchWords(string paramToSearchWords)
        {
            inputFieldnumbers.Click();
            inputFieldnumbers.Clear();
            inputFieldnumbers.SendKeys(paramToSearchWords);
            symbolsGenerationButton.Click();
        }      
        
        public void SearchBytes(string paramToSearchBytes)
        {
            inputFieldnumbers.Click();
            inputFieldnumbers.Clear();
            inputFieldnumbers.SendKeys(paramToSearchBytes);
            symbolsGenerationButton.Click();
        }
    }
}