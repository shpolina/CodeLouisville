﻿using System;

namespace IntermediateDemo
{
    public class RectangleExample2 : IShape
    {
        public RectangleExample2(int height, int widgth)
        {
            Height = height;
            Widgth = widgth;
        }

        public double Area()
        {
            return Height * Widgth;
        }

        public double Perimeter()
        {
            return 2 * Height + 2 * Widgth;
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
