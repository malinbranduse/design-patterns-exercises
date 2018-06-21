using System;

namespace Bridge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var vectorRenderer = new VectorRenderer();
            var triangle = new Triangle(vectorRenderer);
            Console.WriteLine(triangle.ToString());
        }
    }
}
