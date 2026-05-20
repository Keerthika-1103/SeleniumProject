using Allure.NUnit;
using NUnit.Framework;
using NUnitDemoProject.Pages;
using NUnitDemoProject.Tests;
using NUnitDemoProject.Utilities;





namespace NUnitDemoProject.TestDataDir
{

    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class LoginTests : BaseTest
    {

        [Test, TestCaseSource(typeof(ExcelHelper), nameof(ExcelHelper.GetLoginData))]
        public void VerifyLogin(string username, string password)
        {
            Driver.Navigate().GoToUrl(
                    "https://www.saucedemo.com/");

            LoginPage loginPage = new LoginPage(Driver);

            loginPage.Login(username, password);

            Assert.That(Driver.Url.Contains("inventory.html"), Is.True);

        }
    }
}
