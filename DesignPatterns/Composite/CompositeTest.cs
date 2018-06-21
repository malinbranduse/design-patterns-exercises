using System.Collections.Generic;
using NUnit.Framework;

namespace Composite
{
    public class CompositeTest
    {
        [Test()]
        public void TestCompositeSum()
        {
            var singleValue = new SingleValue { Value = 11 };
            var otherValues = new ManyValues();
            otherValues.Add(22);
            otherValues.Add(33);
            Assert.That(new List<IValueContainer> { singleValue, otherValues }.Sum(), Is.EqualTo(66));
        }
    }
}
