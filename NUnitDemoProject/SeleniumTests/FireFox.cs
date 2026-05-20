using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitDemoProject.SeleniumTests
{
    internal class FireFox
    {
        // driver instance at class level
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {// configure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            driver = new FirefoxDriver();
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
        }
        [TearDown]
        public void closebrowser()
        {// it will close the current browser session
            driver.Close();

        }
    }
}
