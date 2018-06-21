using NUnit.Framework;

namespace Bridge
{
    public class BridgeTest
    {
        [Test()]
        public void TestCase()
        {
            var vectorRenderer = new VectorRenderer();
            var triangle = new Triangle(vectorRenderer);
            Assert.AreEqual(triangle.ToString(), "Drawing Triangle as lines");
        }
    }
}
