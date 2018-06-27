using NUnit.Framework;
using System;
namespace Proxy
{
    public class ProxyTest
    {
        [Test()]
        public void TestCase()
        {
            var p = new Person { Age = 17 };
            var rp = new ResponsiblePerson(p);
            Assert.AreNotSame(p.Drink(), rp.Drink());
            Assert.AreSame(p.Drive(), rp.Drive());
            Assert.AreNotSame(p.DrinkAndDrive(), rp.DrinkAndDrive());
        }
    }
}
