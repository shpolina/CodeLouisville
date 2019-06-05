using System;
using System.Collections.Generic;
using System.IO;

namespace DataIO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }

        static void FileExists()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Rectangles.csv");
            var file = new FileInfo(fileName);

            if (file.Exists)
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }
           
        }

        static void ReadIntoObject()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Rectangles.csv");
            var file = new FileInfo(fileName);

            var rectangles = new List<Rectangle>();

            if (file.Exists)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        var items = line.Split(',');

                        string name = items[0];
                        if (!double.TryParse(items[1], out var height))
                        {
                            Console.WriteLine("Can't parse height");
                            continue;
                        }
                        if (!double.TryParse(items[2], out var widgh))
                        {
                            Console.WriteLine("Can't parse widgh");
                            continue;
                        }

                        var rectangle = new Rectangle(items[0], height, widgh);
                        rectangle.Print();
                        rectangles.Add(rectangle);
                    }
                }
            }


           
        }

        static void WriteToFile()
        {
            using (var writer = new StreamWriter(file.FullName, true))
            {
                var line = "Rectangle6,9.5,3";
                writer.WriteLine(line);
            }

        }
    }
}
