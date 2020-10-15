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
    class VerifyTheCheckbox : BaseTest
    {
        public VerifyTheCheckbox(IWebDriver driver) : base(driver)
        {

        }

        [TestMethod]
        public void Test()
        {
            HomePage homepage = new HomePage(driver);
            SearchPage searchPage = new SearchPage(driver);
            homepage.ClickStartWithLoremIpsum();
            homepage.ClickSymbolsGeneration();
            Assert.IsFalse(searchPage.CheckingThePresenceOfAWordLorenIpsumInAParagraph().Contains("Lorem ipsum"));
        }
    }
}
