using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitDemoProject.Drivers
{

    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> driver =
          new ThreadLocal<IWebDriver>();

        public static void InitDriver()
        {
            new DriverManager()
                .SetUpDriver(new EdgeConfig());

            EdgeOptions options =
                new EdgeOptions();

            options.AddArgument("--start-maximized");

            driver.Value =
                new EdgeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void QuitDriver()
        {
            if (driver.Value != null)
            {
                driver.Value.Quit();
                driver.Value.Dispose();

                driver.Value = null;
            }
        }
    }
}