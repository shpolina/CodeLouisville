using System;

namespace IntermediateDemo
{
    public class RectangleExample2 : IShape
    {
        public RectangleExample2(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Width: " + Width);
        }

        public int Height { get; protected set; }
        public int Width { get; protected set; }
    }
}
