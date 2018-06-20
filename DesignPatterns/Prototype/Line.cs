﻿using System;
namespace Prototype
{
    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            return new Line
            {
                Start = new Point { X = Start.X, Y = Start.Y },
                End = new Point { X = End.X, Y = End.Y }
            };
        }
    }
}
