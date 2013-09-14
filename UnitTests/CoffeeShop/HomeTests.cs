using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Controllers;
using NUnit.Framework;

namespace UnitTests.CoffeeShop
{
    [TestFixture]
    public class HomeTests
    {
        [Test]
        public void HomeControllerExists()
        {
            var type = typeof (HomeController);

            Assert.That(type.Name, Is.EqualTo("HomeController"));
        }
    }
}
