using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UnitTestProject;
using UnitTestProject.PageObject;

namespace UnitTestProject1.Tests
{
    [TestClass]
    class CheckingForTextByDefault : BaseTest
    {

        public CheckingForTextByDefault(IWebDriver driver) : base(driver)
        {

        }

        [TestMethod]
        public void Test()
        {
            HomePage homepage = new HomePage(driver);
            SearchPage searchPage = new SearchPage(driver);
            homepage.ClickSymbolsGeneration();
            Assert.IsTrue(searchPage.CheckingsymbolGenerationResult().Contains("Lorem ipsum dolor sit amet, consectetur adipiscing elit"));
        }
    }
}
