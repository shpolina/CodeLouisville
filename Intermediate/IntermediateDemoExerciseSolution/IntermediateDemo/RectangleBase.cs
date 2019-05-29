namespace IntermediateDemo
{
    public abstract class RectangleBase
    {
        public int Area()
        {
            return Height * Widgth;
        }

        public abstract void Print();

        public int Height { get; protected set; }
        public int Widgth { get; protected set; }
    }
}
