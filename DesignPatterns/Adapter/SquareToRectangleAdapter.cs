using System;
namespace Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public SquareToRectangleAdapter(Square square)
        {
            this.Width = square.Side;
            this.Height = square.Side;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }
    }
}
