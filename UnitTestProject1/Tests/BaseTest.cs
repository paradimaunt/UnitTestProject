
using OpenQA.Selenium;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace UnitTestProject
{
    [Binding]
    public class BaseTest
    {
        protected IWebDriver driver;
        private const string LIPSUM_URL = "https://lipsum.com";

        public BaseTest(IWebDriver driver)
        {
            this.driver = driver;
        }

        [TestInitialize]
        public void Setup()
        {
            if (driver == null)
                driver = new ChromeDriver();
            driver.Navigate().GoToUrl(LIPSUM_URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestCleanup]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
