using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitDemoProject.SeleniumTests
{
    public class Dropdown
    {// driver instance at class level
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {// configure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            driver = new EdgeDriver();

        }
        [Test]
        public void testcase1()
        {

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");


            driver.Manage().Window.Maximize();


            Thread.Sleep(5000);


            IWebElement dropdown = driver.FindElement(By.Id("state"));


            // Assert.IsNotNull(dropdown);
            var select = new SelectElement(dropdown);


            // select by visible text - Option2Thread.Sleep(2000);


            select.SelectByText("Rajasthan");


            // select by index - option1Thread.Sleep(2000);

            IWebElement dropdown1 = driver.FindElement(By.Id("city"));


            // Assert.IsNotNull(dropdown);
            var select1 = new SelectElement(dropdown1);


            // select by visible text - Option2Thread.Sleep(2000);


            select1.SelectByText("Agra");




        }
        [TearDown]
        public void closebrowser()
        {// it will close the current browser session
           driver.Close();


        }
    }
}
