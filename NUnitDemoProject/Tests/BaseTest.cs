using NUnitDemoProject.Drivers;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using NUnitDemoProject.Utilities;

namespace NUnitDemoProject.Tests
{
    public class BaseTest
    {
        // protected IWebDriver driver;

        protected IWebDriver Driver =>
             DriverFactory.GetDriver();

        [SetUp]
        public void Setup()
        {
            DriverFactory.InitDriver();
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                if (Driver != null &&
                    TestContext.CurrentContext.Result
                    .Outcome.Status ==
                    TestStatus.Failed)
                {
                    ScreenshotHelper
                        .TakeScreenshot(Driver);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"TearDown Error: {ex.Message}");
            }
            finally
            {
                DriverFactory.QuitDriver();
            }
        }
    }
}