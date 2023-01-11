﻿using OOP_advanced___homework.Exercise1;
using OOP_advanced___homework.Exercise2;
using OOP_advanced___homework.Exercise3;
using OOP_advanced___homework.Exercise4;
using OOP_advanced___homework.Exercise5;
using OOP_advanced___homework.Exercise6;
using OOP_advanced___homework.Exercise7;
using System;


Console.WriteLine("-------------Exercise 1-------------");

BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<Transaction> transactions = myAccount.GetTransactionHistory();
foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction._timestamp}: {transaction._type} ${transaction._amount}");
}

/* Outputs:
[Timestamp of first transaction]: Deposited $500
[Timestamp of second transaction]: Withdrew $200
*/

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine($"Account number: {myAccount.AccountNumber}"); // Outputs 654321
Console.WriteLine($"Account holder: {myAccount.AccountHolder}"); // Outputs "Jane Smith"



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 2-------------");


Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
Console.WriteLine(book.GetPageCount()); // Outputs 180
Console.WriteLine(book.GetCurrentPage()); // Outputs 1

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 2

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 5

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 4

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 3-------------");

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));


foreach (Shape shape in shapes)
{
    Console.WriteLine($"{shape.Color} : {shape.CalculateArea()}");
}

/* Outputs:
Yellow: 120
Purple: 28.2743338823081
Orange: 78.5398163397448
Green: 48
*/

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches"); // Outputs "Total perimeter: 122,26548245744 inches"



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 4--------------");

Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
Console.WriteLine(developer.CalculateBonus()); // Outputs 6000

Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 5--------------");

BankAccountEx5 account1 = new BankAccountEx5("123456", "John Doe", 1000);
BankAccountEx5 account2 = new BankAccountEx5("654321", "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); // Outputs 1500
Console.WriteLine(account2.Balance); // Outputs 1000

Console.WriteLine(account1.GetInterest()); // Outputs 15
Console.WriteLine(account2.GetInterest()); // Outputs 10

Console.WriteLine(Bank.GetNumAccounts()); // Outputs 2



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 6--------------");

IShape circle = new Circle2(5);
IShape rectangle = new Rectangle2(10, 5);

Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
Console.WriteLine(rectangle.CalculateArea()); // Outputs 50

Console.WriteLine(circle.CalculateArea("square feet")); // Outputs "Area: 78.5398163397448 square feet"
Console.WriteLine(rectangle.CalculateArea("square meters")); // Outputs "Area: 50 square meters"

IColor circleColor = (IColor)circle;
circleColor.Color = "Red";

IColor rectangleColor = (IColor)rectangle;
rectangleColor.Color = "Blue";

Console.WriteLine(circleColor.Color); // Outputs "Red"
Console.WriteLine(rectangleColor.Color); // Outputs "Blue"



Console.WriteLine();
Console.WriteLine("-------------EXERCISE 7--------------");

RentedRoom room1 = new RentedRoom(6);
RentedRoom room2 = new RentedRoom(2);

room1.GreetingGuest();
Console.WriteLine($"You must pay ${room1.GetRoomPrice()}.");
room1.SpecialMessage();
Console.WriteLine(room1.CanRentPool());
Console.WriteLine();

room2.GreetingGuest();
Console.WriteLine($"You must pay ${room2.GetRoomPrice()}.");
room2.SpecialMessage();
Console.WriteLine(room2.CanRentPool());
Console.WriteLine();

Hotel.RoomCheckout();
Hotel.RoomCheckout("Goodbye");
Console.WriteLine();

RentedRoom room3 = new RentedRoom(1);
room3.GreetingGuest();
Console.WriteLine($"You must pay ${room3.GetRoomPrice()}");
room3.ChangeTowels();
room3.RoomReady();
Hotel.RoomCheckout();
Hotel.RoomCheckout("Byeee");