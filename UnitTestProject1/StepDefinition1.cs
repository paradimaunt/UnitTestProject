using OpenQA.Selenium;
using System.Linq;
using TechTalk.SpecFlow;
using UnitTestProject.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [Binding]
    public sealed class StepDefinition1
    {

        HomePage homePage = new HomePage(Hooks.Hooks.driver);
        //SearchPage searchPage = new SearchPage(driver);

        [Given(@"Lorem ipsum home page is open")]
        public void GivenLoremIpsumHomePageIsOpen()
        {
            Hooks.Hooks.driver.Navigate().GoToUrl("https://lipsum.com");
        }

        [When(@"I click russian language item")]
        public void WhenIClickRussianLanguageItem()
        {
            homePage.ClickChangeLanguageToRussianButton();
        }
        [Then(@"the result should contains the world ""(.*)""")]
        public void ThenTheResultShouldContainsTheWorld(string word)
        {
            Assert.IsTrue(homePage.CheckingThePresenceOfAWordInAParagraph().Contains(word));
        }
        [When(@"I click generation button")]
        public void WhenIClickGenerationButton()
        {
            homePage.ClickSymbolsGeneration();
        }
        [Then(@"the result should start with ""(.*)""")]
        public void ThenTheResultShouldStartWith(string word)
        {
            SearchPage searchPage = new SearchPage(Hooks.Hooks.driver);
            Assert.IsTrue(searchPage.CheckingsymbolGenerationResult().First().Contains(word));
        }
        [When(@"I click unchek start checkbox")]
        public void WhenIClickUnchekStartCheckbox()
        {
            homePage.ClickStartWithLoremIpsum();
        }
        [Then(@"the result should't start with ""(.*)""")]
        public void ThenTheResultShouldTStartWith(string word)
        {
            SearchPage searchPage = new SearchPage(Hooks.Hooks.driver);
            Assert.IsFalse(searchPage.CheckingThePresenceOfAWordLorenIpsumInAParagraph().Contains(word));
        }
        [When(@"I run generate paragraphs")]
        public void WhenIRunGenerateParagraphs()
        {
            homePage.ClickSymbolsGeneration();          
        }
        [Then(@"everage numbers should by between (.*) and (.*)")]
        public void ThenEverageNumbersShouldByBetweenAnd(int p0, int p1)
        {
            var counter = 0;

            for(int i = 0; i < 10; i++)
            {
                SearchPage searchPage = new SearchPage(Hooks.Hooks.driver);
                counter += searchPage.GeneratingParagraphsThatHaveTheWordLorem();
                GivenLoremIpsumHomePageIsOpen();
                WhenIRunGenerateParagraphs();
            }
            var average = counter / 10;
            Assert.IsTrue(average >= p0 && average <= p1);
        }
        [When(@"I generate (.*) bytes of text default starting text")]
        public void WhenIGenerateBytesOfTextDefaultStartingText(string paramToSearchBytes)
        {
            homePage.ClickBytesButton();
            homePage.SearchBytes(paramToSearchBytes);
        }
        [Then(@"(.*) bytes has been found on the page")]
        public void ThenBytesHasBeenFoundOnThePage(int paramToSearchBytes)
        {
            SearchPage searchPage = new SearchPage(Hooks.Hooks.driver);
            Assert.AreEqual(paramToSearchBytes, searchPage.CountBytes(), "Incorect Input");
        }
        [When(@"I generate (.*) words of text default starting text")]
        public void WhenIGenerateWordsOfTextDefaultStartingText(string paramToSearchWords)
        {
            homePage.ClickWordsButton();
            homePage.SearchWords(paramToSearchWords);
        }
        [Then(@"(.*) words has been found on the page")]
        public void ThenWordsHasBeenFoundOnThePage(int paramToSearchWords)
        {
            SearchPage searchPage = new SearchPage(Hooks.Hooks.driver);
            Assert.AreEqual(paramToSearchWords, searchPage.CountWords(), "Incorect Input");
        }
    }
}
