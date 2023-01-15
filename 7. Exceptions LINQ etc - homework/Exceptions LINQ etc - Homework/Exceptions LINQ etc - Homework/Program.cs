using Exceptions_LINQ_etc___Homework.Exercise1;
using Exceptions_LINQ_etc___Homework.Exercise2;
using Exceptions_LINQ_etc___Homework.Exercise3;
using System.Globalization;
using System.IO;

//Console.WriteLine(" ------ EXERCISE 1 ------");
//DateChecker date1 = new DateChecker("14.01.2222");
//DateChecker date2 = new DateChecker("14.01.1900");      //uncomment line 8 if you want to check the exception
//date1.RunDateChecker();
////date2.RunDateChecker();      

//Console.WriteLine();
//Console.WriteLine(" ------ EXERCISE 2 ------");
//NameChecker names = new NameChecker();
//names.ReadAndCheckName();

//Console.WriteLine();
//Console.WriteLine(" ------ EXERCISE 3 ------");
//SumAndAverage calculator1 = new SumAndAverage();
//calculator1.Calculator();

Console.WriteLine();
Console.WriteLine(" ------ EXERCISE 3 ------");
string path = @"D:\\WANTSOME\\Github\\fbidihon-net7-homework\\7. Exceptions LINQ etc - homework\\Exceptions LINQ etc - Homework\\Exceptions LINQ etc - Homework\\Exercise4\\textFile.txt";
string textFile = File.ReadAllText(path);
Console.WriteLine(textFile);

try
{
    string path2 = @"D:\\WANTSOME\\Github\\fbidihon-net7-homework\\7. Exceptions LINQ etc - homework\\Exceptions LINQ etc - Homework\\Exceptions LINQ etc - Homework\\Exercise4\\unexistingFile.txt";
    string unexistingFile = File.ReadAllText(path2);
    Console.WriteLine(unexistingFile);
}
catch(FileNotFoundException exception)
{
    Console.WriteLine(exception.Message);
    Console.WriteLine("The file you are searching for doesn't exist.");
}