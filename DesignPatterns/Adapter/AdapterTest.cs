using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Adapter
{
    public class AdapterTest
    {
        [Test()]
        public void TestCase()
        {
            var square = new Square() { Side = 4 };
            var rect = new SquareToRectangleAdapter(square);
            Assert.That(rect.Width, Is.EqualTo(4));
            Assert.That(rect.Height, Is.EqualTo(4));
        }
    }
}
