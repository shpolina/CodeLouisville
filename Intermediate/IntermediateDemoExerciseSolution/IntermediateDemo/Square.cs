using System;

namespace IntermediateDemo
{
    class Square : Rectangle
    {
        public Square(int side)
            : base(side, side)
        {
           
        }

        public void Stretch(int factor)
        {
            Height = Height * factor;
            Widgth = Widgth * factor;
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I am a sqaure");
        }
    }
}
