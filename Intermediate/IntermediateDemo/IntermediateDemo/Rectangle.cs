using System;

namespace IntermediateDemo
{
    public class Rectangle 
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Area()
        {
            return Height * Width;
        }

        public void Print()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Width: " + Width);
        }

        public override string ToString()
        {
            return "Height: " + Height + "\nWidth: " + Width;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a rectangle");
        }

        public static bool Compare(Rectangle rec1, Rectangle rec2)
        {
            if (rec1.Height == rec2.Height &&
                rec1.Width == rec2.Width)
            {
                return true;
            }
            return false;
        }

        public int Height { get; protected set; }
        public int Width { get; protected set; }
    }
}
