using System;

namespace IntermediateDemo
{
    public class RectangleExample1 : RectangleBase
    {
        public RectangleExample1(int height, int widgth)
        {
            Height = height;
            Widgth = widgth;
        }

        public override void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Widgth: " + Widgth);
        }
    }
}
