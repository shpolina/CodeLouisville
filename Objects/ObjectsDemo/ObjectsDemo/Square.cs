namespace ObjectsDemo
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
    }
}
