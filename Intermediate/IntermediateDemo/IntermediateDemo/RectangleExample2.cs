using System;

namespace IntermediateDemo
{
    public class RectangleExample2 : IShape
    {
        public RectangleExample2(int height, int widgth)
        {
            Height = height;
            Widgth = widgth;
        }

        public int Area()
        {
            return Height * Widgth;
        }

        public void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Widgth: " + Widgth);
        }

        public int Height { get; protected set; }
        public int Widgth { get; protected set; }
    }
}
