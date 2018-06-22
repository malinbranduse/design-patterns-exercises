using NUnit.Framework;
using System;
namespace Decorator
{
    public class DecoratorTest
    {
        [Test()]
        public void TestCase()
        {
            var bird = new Bird { Age = 9 };
            var lizard = new Lizard { Age = 9 };
            var dragon = new Dragon { Age = 9 };
            Assert.AreEqual(dragon.Fly(), bird.Fly());
            Assert.AreEqual(dragon.Crawl(), lizard.Crawl());
        }
    }
}
