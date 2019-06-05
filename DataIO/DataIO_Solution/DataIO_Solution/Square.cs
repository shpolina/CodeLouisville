using System;

namespace DataIO_Solution
{
    class Square : Rectangle
    {
        public Square(string name, double side)
            : base(name, side, side)
        {
        }

        public void Stretch(int factor)
        {
            Height = Height * factor;
            Width = Width * factor;
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I am a sqaure");
        }
    }
}
