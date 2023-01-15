using Exceptions_LINQ_etc___Homework.Exercise1;
using Exceptions_LINQ_etc___Homework.Exercise2;
using Exceptions_LINQ_etc___Homework.Exercise3;
using Exceptions_LINQ_etc___Homework.Exercise4;
using System.Globalization;
using System.IO;

Console.WriteLine(" ------ EXERCISE 1 ------");
DateChecker date1 = new DateChecker("14.01.2222");
DateChecker date2 = new DateChecker("14.01.1900");      //uncomment line 8 if you want to check the exception
date1.RunDateChecker();
//date2.RunDateChecker();      

Console.WriteLine();
Console.WriteLine(" ------ EXERCISE 2 ------");
NameChecker names = new NameChecker();
names.ReadAndCheckName();

Console.WriteLine();
Console.WriteLine(" ------ EXERCISE 3 ------");
SumAndAverage calculator1 = new SumAndAverage();
calculator1.Calculator();

Console.WriteLine();
Console.WriteLine(" ------ EXERCISE 3 ------");
FilesExercise.Run();
