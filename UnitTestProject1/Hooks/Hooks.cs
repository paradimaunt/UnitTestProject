using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Hooks
{
    [Binding]
    class Hooks
    {
        public static IWebDriver driver;

        public Hooks()
        {
            driver = new ChromeDriver();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}

