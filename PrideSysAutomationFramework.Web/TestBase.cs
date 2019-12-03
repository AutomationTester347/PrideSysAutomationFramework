using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PrideSysAutomationFramework.Web
{
    [TestFixture]
    public abstract class TestBase
    {
        internal static IWebDriver driver;

        [SetUp]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl("https://www.daraz.com.bd/");
        }

        [TearDown]
        public void TestCleanUp()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static void BeginExecution()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();
        }

        public static void ExitExecution()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
