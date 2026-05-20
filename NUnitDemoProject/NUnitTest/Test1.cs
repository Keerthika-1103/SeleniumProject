using Allure.NUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitDemoProject.NUnitTest
{
    [AllureNUnit]
    internal class Test1
    {
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logging in the application");

        }
        
        [Test, Order(2)]
        public void productsdisplay()
        {
            Console.WriteLine("Products display");

        }
        [Test, Order(3)]
        public void addtocart()
        {
            Console.WriteLine("Item added to cart");

        }
        [Test, Order(4)]
        public void logout()
        {
            Console.WriteLine("Logged out of the application");

        }
        [Test]
        public void payment()
        {
            Console.WriteLine("Payment done");
        }
    }
}
