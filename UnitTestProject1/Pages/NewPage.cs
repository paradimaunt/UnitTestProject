using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Linq;

namespace UnitTestProject.PageObject
{
    public class NewPage : BasePage
    {

        public NewPage(IWebDriver driver) : base(driver)
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

        [FindsBy(How = How.XPath, Using = "//label[contains(@for, 'bytes')]")]
        private IWebElement fieldBytesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@for, 'words')]")]
        private IWebElement fieldWordsButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='Panes']//p[contains(text(), 'это текст')]")]
        private IWebElement findTextInAParagraph { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'lipsum')]//p")]
        private IWebElement symbolGenerationResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p[contains(text(), 'Lorem ipsum')]")]
        private IWebElement findingTheTextLoremIpsum { get; set; }

        public void ClickChangeLanguageToRussianButton()
        {
            changeLanguageToRussianButton.Click();
        }

        public string CheckingThePresenceOfAWordInAParagraph()
        {
            return findTextInAParagraph.Text;
        }

        public void ClickSymbolsGeneration()
        {
            symbolsGenerationButton.Click();
        }

        public void ClickStartWithLoremIpsum()
        {
            startWithLoremIpsumButton.Click();
        }

        public void ClickWordsButton()
        {
            fieldWordsButton.Click();
        }

        public void SearchWords(string paramToSearchWords)
        {
            inputFieldnumbers.Click();
            inputFieldnumbers.Clear();
            inputFieldnumbers.SendKeys(paramToSearchWords);
            symbolsGenerationButton.Click();
        }

        public void ClickBytesButton()
        {
            fieldBytesButton.Click();
        }

        public void SearchBytes(string paramToSearchBytes)
        {
            inputFieldnumbers.Click();
            inputFieldnumbers.Clear();
            inputFieldnumbers.SendKeys(paramToSearchBytes);
            symbolsGenerationButton.Click();
        }

        public string CheckingsymbolGenerationResult()
        {
            return symbolGenerationResult.Text;
        }

        public string CheckingThePresenceOfAWordLorenIpsumInAParagraph()
        {
            return findingTheTextLoremIpsum.Text;
        }

        public int CountWords()
        {
            string serchResult = symbolGenerationResult.Text;
            string[] arr = serchResult.Split(' ');
            return arr.Length;
        }

        public int CountBytes()
        {
            int countSymbols = symbolGenerationResult.Text.ToCharArray().Length;
            return countSymbols;
        }

        //public int GeneratingParagraphsThatHaveTheWordLorem()
        //{
        //    string wordInParagraph = "lorem";

        //    var wordCount = CheckingsymbolGenerationResult().Where(a => a.Contains(wordInParagraph)).ToList().Count;
        //    return wordCount;
        //}
    }
}
