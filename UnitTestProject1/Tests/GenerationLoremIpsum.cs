using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnitTestProject;
using UnitTestProject.PageObject;

namespace UnitTestProject1.Tests
{
    [TestClass]
    class GenerationLoremIpsum : BaseTest
    {
        public GenerationLoremIpsum(IWebDriver driver) : base(driver)
        {

        }

        [DataTestMethod]
        [DataRow(-1, 5)]
        [DataRow(0, 5)]
        [DataRow(5, 5)]
        [DataRow(10, 10)]
        [DataRow(20, 20)]
        public void InputNumbersInTheFieldWodrs(string paramToSearchWords)
        {
            HomePage homepage = new HomePage(driver);
            SearchPage searchPage = new SearchPage(driver);
            homepage.ClickWordsButton();
            homepage.SearchWords(paramToSearchWords);
            Assert.AreEqual(paramToSearchWords, searchPage.CountWords(), "Incorect Input");
        }

        [DataTestMethod]
        [DataRow(-5, 5)]
        [DataRow(0, 5)]
        [DataRow(20, 20)]
        public void InputNumbersInTheFieldBytes(string paramToSearchBytes)
        {
            HomePage homepage = new HomePage(driver);
            SearchPage searchPage = new SearchPage(driver);
            homepage.ClickBytesButton();
            homepage.SearchBytes(paramToSearchBytes);
            Assert.AreEqual(paramToSearchBytes, searchPage.CountBytes(), "Incorect Input");
        }
    }
}
