using NUnit.Framework;

namespace Prototype
{
    public class PrototypeTest
    {
        [Test()]
        public void TestCase()
        {
            var line = new Line
            {
                Start = new Point() { X = 10, Y = 20 },
                End = new Point() { X = 1, Y = 2 },
            };
            var helpNeedLineCopy = line.DeepCopy();
            Assert.AreEqual(line.Start.X, helpNeedLineCopy.Start.X);
            Assert.AreEqual(line.Start.Y, helpNeedLineCopy.Start.Y);

            Assert.AreEqual(line.End.X, helpNeedLineCopy.End.X);
            Assert.AreEqual(line.End.Y, helpNeedLineCopy.End.Y);
        }
    }
}
