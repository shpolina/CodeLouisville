using System;

namespace ObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of type rectangle
            var rectangle = new Rectangle(4, 5);

            //print rectangle
            Console.WriteLine("Rectangle dimensions are: ");
            rectangle.Print();

            //calculate rectangle area
            var area = rectangle.Area();

            //print area
            Console.WriteLine("The area of rectangle is: " + area);

            //compare two rectangles and print result
            var rectangle1 = new Rectangle(7, 9);
            var rectangle2 = new Rectangle(1, 5);

            var isEqual = Rectangle.Compare(rectangle1, rectangle2);
            Console.WriteLine("Comparing rectangle1 and rectangle2");
            Console.WriteLine("IsEqual: " + isEqual);

            //creating square object that inherits from Rectangle
            var square = new Square(5);

            //stretch square 
            square.Stretch(2);

            //square inherits all the methods of Rectangle
            //so we can use Print() function on square
            Console.WriteLine("Square dimensions are: ");
            square.Print();

            ////////////////////////////////////////////
            //Arrays
            ////////////////////////////////////////////


            //declaring and intializing array of integers with legth 5
            var numbers = new int[]
            {
                1, 2, 3, 4, 5
            };
            //putting value 100 into cell 0 of "numbers" array
            numbers[0] = 100;

            //array of rectangles
            var rectangles = new Rectangle[]
            {
                new Rectangle(3,4),
                new Square(5)  //<- Suare Is-A Rectangle
            };

            //array of squares
            var squares = new Square[]
            {
                new Square(3),
                new Square(7)
            };


            //printing elements of "squares" array
            Console.WriteLine("Printing elements of array of Sqaures");
            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine("Sqaure at index " + i);
                squares[i].Print(); //each element is of type Square so we can call Print() on it
            }

            Console.ReadLine();
        }
    }
}
