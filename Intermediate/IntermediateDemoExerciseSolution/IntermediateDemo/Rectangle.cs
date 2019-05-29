using System;

namespace IntermediateDemo
{
    public class Rectangle 
    {
        public Rectangle(int height, int widgth)
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

        public override string ToString()
        {
            return "Height: " + Height + "\nWidgth: " + Widgth;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a rectangle");
        }

        public static bool Compare(Rectangle rec1, Rectangle rec2)
        {
            if (rec1.Height == rec2.Height &&
                rec1.Widgth == rec2.Widgth)
            {
                return true;
            }
            return false;
        }

        public int Height { get; protected set; }
        public int Widgth { get; protected set; }
    }
}
