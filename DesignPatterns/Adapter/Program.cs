using System;

namespace Adapter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var square = new Square() { Side = 4 };
            var rect = new SquareToRectangleAdapter(square);
            Console.WriteLine($"{rect.Height}, {rect.Width}");
        }
    }
}
