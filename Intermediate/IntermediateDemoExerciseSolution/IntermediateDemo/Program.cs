using System;

namespace IntermediateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);

            circle.Print();

            var area = circle.Area();

            Console.WriteLine("Circle Area is: " + area);

            Console.ReadLine();
        }
    }
}
