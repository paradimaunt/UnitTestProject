using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject;
using UnitTestProject.PageObject;

namespace UnitTestProject1.Tests
{
    [TestClass]
    class SearchTextByParagraph : BaseTest
    {
        public SearchTextByParagraph(IWebDriver driver) : base(driver)
        {

        }
        [TestMethod]
        public void Test()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickChangeLanguageToRussianButton();
            Assert.IsTrue(homePage.CheckingThePresenceOfAWordInAParagraph().Contains("рыба"));
        }
    }
}
