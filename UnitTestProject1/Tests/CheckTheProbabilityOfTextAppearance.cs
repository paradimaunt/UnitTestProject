//using OpenQA.Selenium;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UnitTestProject;
//using UnitTestProject.PageObject;

//namespace UnitTestMethodProject
//{
//    [TestClass]
//    public class CheckTheProbabilityOfTextAppearance : BaseTest
//    {

//        public CheckTheProbabilityOfTextAppearance(IWebDriver driver) : base(driver)
//        {

//        }

//        [TestMethod]
//        public void Test()
//        {
//            HomePage homepage = new HomePage(driver);
//            SearchPage searchPage = new SearchPage(driver);
//            homepage.ClickSymbolsGeneration();
//            searchPage.GeneratingParagraphsThatHaveTheWordLorem();
//            Assert.AreEqual(3, searchPage.GeneratingParagraphsThatHaveTheWordLorem());
//        }
//    }
//}