using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions_LINQ_etc___Homework.Exercise4
{
    public static class FilesExercise
    {
        public static void Run()
        {           
            Console.WriteLine("Insert a file name to check if it exists:");
            string fileToCheck = Console.ReadLine();
            string path = @"D:\\WANTSOME\\Github\\fbidihon-net7-homework\\7. Exceptions LINQ etc - homework\\Exceptions LINQ etc - Homework\\Exceptions LINQ etc - Homework\\Exercise4\\" + $"{fileToCheck}";

            if (File.Exists(path) && File.ReadAllText(path) == "")
            {
                Console.WriteLine("File is empty.");
                Console.WriteLine("Enter some text to write to the file: ");
                string addText = Console.ReadLine();
                File.AppendAllText(path, addText);
                string readTextFile = File.ReadAllText(path);
                Console.WriteLine($"File contents: \n{readTextFile}");
            }
            else if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist");
                Console.WriteLine("Enter some text to write to the file: ");
                string addText = Console.ReadLine();
                File.AppendAllText(path, addText);
                string readTextFile = File.ReadAllText(path);
                Console.WriteLine($"File contents: \n{readTextFile}");
            }
            else
            {
                string fileAlreadyExists = File.ReadAllText(path);
                Console.WriteLine($"File already exists. File contents: \n{fileAlreadyExists}");
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("Insert a file name to check if it exists: (psssst! Search for something unexisting) ");
                string fileToCheck2 = Console.ReadLine();
                string path2 = @"D:\\WANTSOME\\Github\\fbidihon-net7-homework\\7. Exceptions LINQ etc - homework\\Exceptions LINQ etc - Homework\\Exceptions LINQ etc - Homework\\Exercise4\\" + $"{fileToCheck2}";
                string readTextFile2 = File.ReadAllText(path2);
                Console.WriteLine($"File contents: \n{readTextFile2}");
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("ERROR: the file you are searching for does not exist.");
            }
        }
    }
}
