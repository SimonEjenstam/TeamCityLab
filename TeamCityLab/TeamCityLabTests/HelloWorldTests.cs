using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamCityLabTests
{
    [TestFixture]
    class HelloWorldTests
    {

        [Test]
        public void should_pass()
        {
            Assert.AreEqual(1,1);
        }

        [Test]
        public void should_not_pass()
        {
            Assert.AreEqual(1, 0);
        }
    }
}
