using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using SeleniumExtras.PageObjects;

namespace UnitTestProject.PageObject
{
    public class SearchPage : BasePage
    {

        public SearchPage(IWebDriver driver) : base(driver)
        {

        }
      
        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'lipsum')]//p")]
        private IList<IWebElement> symbolGenerationResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']//p[1]")]
        private IWebElement findingTheTextLoremIpsum { get; set; }

        public List<string> CheckingsymbolGenerationResult()
        {
            return symbolGenerationResult.Select(a => a.Text).ToList();
        }

        public string CheckingThePresenceOfAWordLorenIpsumInAParagraph()
        {
            return findingTheTextLoremIpsum.Text;
        }

        public int CountWords()
        {
            string serchResult = findingTheTextLoremIpsum.Text;
            string[] arr = serchResult.Split(' ');
            return arr.Length;
        }

        public int CountBytes()
        {
            int countSymbols = findingTheTextLoremIpsum.Text.ToCharArray().Length;
            return countSymbols;
        }

        public int GeneratingParagraphsThatHaveTheWordLorem()
        {
            string wordInParagraph = "lorem";

            var wordCount = CheckingsymbolGenerationResult().Where(a => a.Contains(wordInParagraph)).ToList().Count;
            return wordCount;
        }
    }
}
