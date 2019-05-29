using System;

namespace IntermediateDemo
{
    class Circle : IShape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return Math.PI * 3.14 * Radius;
        }

        public void Print()
        {
            Console.WriteLine("Radius: " + Radius);
        }

        public override string ToString()
        {
            return "Height: " + Radius;
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a circle");
        }

        public static bool Compare(Circle circle1, Circle circle2)
        {
            if (circle1.Radius == circle2.Radius)
            {
                return true;
            }
            return false;
        }

        public double Radius { get; protected set; }
    }
}
