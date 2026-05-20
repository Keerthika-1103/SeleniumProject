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
    public class SauceDemo
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();


            IWebElement userName = driver.FindElement(By.CssSelector("#user-name"));
            userName.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='password']"));
            password.SendKeys("secret_sauce");

            driver.FindElement(By.XPath("//input[@id='login-button']")).Click();

            IWebElement addToCart = driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
            addToCart.Click();

            IWebElement cartLink = driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            cartLink.Click();

            string actualText = driver.FindElement(By.XPath("//div[@class='inventory_item_name']")).Text;
            Assert.That(actualText, Is.EqualTo("Sauce Labs Backpack"));

            
            IWebElement checkout = driver.FindElement(By.XPath("//button[@id='checkout']"));
            checkout.Click();

            
            IWebElement firstName = driver.FindElement(By.XPath("//input[@id='first-name']"));
            firstName.SendKeys("Keerthi");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@id='last-name']"));
            lastName.SendKeys("A");
            IWebElement postCode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            postCode.SendKeys("639136");
            

            IWebElement continueButton = driver.FindElement(By.XPath("//input[@id='continue']"));
            continueButton.Click();
            
            IWebElement finishButton = driver.FindElement(By.XPath("//button[@id='finish']"));
            finishButton.Click();

            string actualFinalMessage = driver.FindElement(By.CssSelector(".complete-header")).Text;
            Assert.That(actualFinalMessage, Is.EqualTo("Thank you for your order!"));
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }
    }
}
