using System;

namespace IntermediateDemo
{
    public class RectangleExample1 : RectangleBase
    {
        public RectangleExample1(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Width: " + Width);
        }
    }
}
