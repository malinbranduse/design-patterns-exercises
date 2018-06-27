using NUnit.Framework;
using System;
namespace Flyweight
{
    public class FlyweightTest
    {
        [Test()]
        public void TestCase()
        {
            var sentence = new Sentence("hello wonderful world!");
            sentence[1].Capitalize = true;
            var s = sentence.ToString();
            Assert.AreEqual(s, "hello WONDERFUL world!");
        }
    }
}
