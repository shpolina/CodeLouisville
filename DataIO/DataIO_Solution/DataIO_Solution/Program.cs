using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataIO_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            ReadSquaresAndPrintArea();
            WriteSquare();

            //Part 2
            var squares = ReadSquaresFromJson();
            WriteSquaresToJson(squares);

            Console.ReadLine();
        }

        static void ReadSquaresAndPrintArea()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Squares.csv");
            var file = new FileInfo(fileName);

            if (file.Exists)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        var items = line.Split(',');

                        string name = items[0];
                        if (!double.TryParse(items[1], out var side))
                        {
                            Console.WriteLine("Can't parse height");
                            continue;
                        }


                        var square = new Square(items[0], side);
                        square.Print();
                        Console.WriteLine("Area: " + square.Area());
                    }
                }
            }
        }

        static void WriteSquare()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Squares.csv");
            var file = new FileInfo(fileName);

            if (file.Exists)
            {
                using (var writer = new StreamWriter(file.FullName, true))
                {
                    var line = "SquareNew,6.4";
                    writer.WriteLine(line);
                }
            }
        }


        static List<Square> ReadSquaresFromJson()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Squares.json");
            var file = new FileInfo(fileName);

            var squares = new List<Square>();

            if (file.Exists)
            {
                var serializer = new JsonSerializer();
                using (var reader = new StreamReader(file.FullName))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    squares = serializer.Deserialize<List<Square>>(jsonReader);
                    foreach (var square in squares)
                    {
                        square.Print();
                        Console.WriteLine("Area: " + square.Area());
                    }
                }
            }

            return squares;
        }

        static void WriteSquaresToJson(List<Square> sqaures)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "SquaresNew.json");
            var file = new FileInfo(fileName);
           
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(file.FullName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, sqaures);
            }
        }
    }
}
