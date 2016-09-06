using jubilant.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jubilant.UnitTests
{
    [TestFixture]
    class HomeControllerTests
    {
        [Test]
        public void CheckIndexExists()
        {
            var sut = new HomeController();

            var result = sut.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
        [Test]
        public void CheckAboutExists()
        {
            var sut = new HomeController();

            var result = sut.About() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
