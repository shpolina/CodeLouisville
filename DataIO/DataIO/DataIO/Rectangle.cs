using System;

namespace DataIO
{
    public class Rectangle : IShape
    {
        public Rectangle(string name, double height, double width)
        {
            Height = height;
            Width = width;
            Name = name;
        }

        public double Area()
        {
            return Height * Width;
        }

        public void Print()
        {
            Console.WriteLine("Rectangle Name: " + Name);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Width: " + Width);
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a rectangle");
        }

        public double Height { get; protected set; }
        public double Width { get; protected set; }
        public string Name { get; protected set; }
    }
}
