using Allure.NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitDemoProject.EndToEndAutomation
{
    [AllureNUnit]
    [TestFixture]
    public class TutorialsPointDemo
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
        }

        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
            driver.Manage().Window.Maximize();


            IWebElement name = driver.FindElement(By.XPath("//input[@id='name']"));
            name.SendKeys("Keerthika");
            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("keerthi@gmail.com");

            IWebElement gender = driver.FindElement(By.XPath("(//input[@type='radio'])[2]"));
            gender.Click();

            IWebElement mobileNo = driver.FindElement(By.XPath("//input[@id='mobile']"));
            mobileNo.SendKeys("9876543210");


            IWebElement dob = driver.FindElement(By.XPath("//input[@id='dob']"));
            dob.SendKeys("11/03/2002");



            IWebElement subjects = driver.FindElement(By.CssSelector("#subjects"));
            subjects.SendKeys("Computer Science, Maths, Chemistry");
            IWebElement hobbiesCheckBox = driver.FindElement(By.XPath("(//input[@type='checkbox'])[3]"));
            hobbiesCheckBox.Click();
            IWebElement address = driver.FindElement(By.XPath("//textarea[@id='picture']"));
            address.SendKeys("Church Street, Oppsite to ABC school");




            IWebElement upload = driver.FindElement(By.XPath("//input[@id='picture']"));
            upload.SendKeys("C:\\Users\\cloudcomm\\Documents\\uploadFile.JPG");

            //Assert.That(upload.Text, Does.Contain("uploadFile"));

            IWebElement dropdownState = driver.FindElement(By.Id("state"));
            var select = new SelectElement(dropdownState);
            select.SelectByText("Rajasthan");

            IWebElement dropdownCity = driver.FindElement(By.Id("city"));
            var select1 = new SelectElement(dropdownCity);
            select1.SelectByText("Agra");


            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
            loginButton.Click();

        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
