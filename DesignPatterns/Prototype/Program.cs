using System;

namespace Prototype
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var line = new Line
            {
                Start = new Point() { X = 10, Y = 20 },
                End = new Point() {X = 1, Y = 2},
            };
            var helpNeedLineCopy = line.DeepCopy();
        }
    }
}
