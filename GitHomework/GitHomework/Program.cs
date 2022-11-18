
// Exercise 1  - the input for the double numbers has to be written with a coma, like this: 12,9
Console.WriteLine("Insert the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insert the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double Addition = number1 + number2;
double Subtraction = number1 - number2;
double Division = number1 / number2;
double Multiplication = number1 * number2;

Console.WriteLine($"Addition = {Addition}");
Console.WriteLine($"Subtraction = {Subtraction}");
Console.WriteLine($"Division = {Division}");
Console.WriteLine($"Multiplication = {Multiplication}");


// Exercise 2
List<int> numbers = new List<int>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Insert a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    numbers.Add(num);
}
Console.WriteLine("Minimum number is " + numbers.Min(z => z));
Console.WriteLine("Maximum number is " + numbers.Max(z => z));


// Exercise 3
Console.WriteLine("Insert a number of days");
int input = Convert.ToInt32(Console.ReadLine());
int years = input / 365;
int daysLeft1 = input % 365;
int months = daysLeft1 / 30;
int days = daysLeft1 % 30;

if (years >= 2 && months >= 2)
    Console.WriteLine($"{years} years, {months} months, {days} days");
else if (years < 2 && months < 2)
    Console.WriteLine($"{years} year, {months} month, {days} days");
else if (years < 2)
    Console.WriteLine($"{years} year, {months} months, {days} days");
else
    Console.WriteLine($"{years} years, {months} month, {days} days");


// Exercise 4
Console.WriteLine("Introdu primul numar.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introdu al doilea numar.");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introdu al treilea numar.");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 && num1 < num3)
    Console.WriteLine($"Minimum number is {num1}");
else if (num2 < num1 && num2 < num3)
    Console.WriteLine($"Minimum number is {num2}");
else
    Console.WriteLine($"Minimum number is {num3}");

if (num1 > num2 && num1 > num3)
    Console.WriteLine($"Maximum number is {num1}");
else if (num2 > num1 && num2 > num3)
    Console.WriteLine($"Maximum number is {num2}");
else
    Console.WriteLine($"Maximum number is {num3}");


// Exercise 5
Console.WriteLine("Enter the Physics mark: ");
int physics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Chemistry mark: ");
int chemistry = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Biology mark: ");
int biology = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mathematics mark: ");
int mathematics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Computer Science mark: ");
int computerScience = Convert.ToInt32(Console.ReadLine());

double sum = physics + chemistry + biology + mathematics + computerScience;
double average = sum / 5;
string averageString = average.ToString("0.##");
if (average % 1 == 0)
{
    averageString = $"{averageString}.00";
}
string grade = " ";
if (average >= 90)
    grade = "A";
else if (average < 90 && average >= 80)
    grade = "B";
else if (average < 80 && average >= 70)
    grade = "C";
else if (average < 70 && average >= 60)
    grade = "D";
else if (average < 60 && average >= 40)
    grade = "E";
else
    grade = "F";

Console.WriteLine($"Percentage = {averageString} and grade is {grade}");


// Exercise 6
Console.WriteLine("Type in one of the following grades: E, V, G, A or F");
string input6 = Console.ReadLine();
if (input6 == "E" || input6 == "e")
    Console.WriteLine("Excellent");
else if (input6 == "V" || input6 == "v")
    Console.WriteLine("Very Good");
else if (input6 == "G" || input6 == "g")
    Console.WriteLine("Good");
else if (input6 == "A" || input6 == "a")
    Console.WriteLine("Average");
else if (input6 == "F" || input6 == "f")
    Console.WriteLine("Fail");
else
    Console.WriteLine("You did not type a valid grade. Try again.");


// Exercise 7
Console.WriteLine("Choose a month number from 1 to 12 and I will tell you which month is it: ");
int numb = Convert.ToInt32(Console.ReadLine());
string word = " ";
if (numb == 1)
    word = "January";
else if (numb == 2)
    word = "February";
else if (numb == 3)
    word = "March";
else if (numb == 4)
    word = "April";
else if (numb == 5)
    word = "May";
else if (numb == 6)
    word = "June";
else if (numb == 7)
    word = "July";
else if (numb == 8)
    word = "August";
else if (numb == 9)
    word = "September";
else if (numb == 10)
    word = "October";
else if (numb == 11)
    word = "November";
else if (numb == 12)
    word = "December";
else
    Console.WriteLine("You did not type a valid month. Try again.");
Console.WriteLine(word);


// Exercise 8
Console.WriteLine("How many centigrades are outside? ");
int input8 = Convert.ToInt32(Console.ReadLine());
string conclusion = " ";
if (input < 0)
    conclusion = "Freezing weather";
else if (input == 0 || input < 10)
    conclusion = "Very Cold weather";
else if (input == 10 || input < 20)
    conclusion = "Cold weather";
else if (input == 20 || input < 30)
    conclusion = "Normal in Temp";
else if (input == 30 || input < 40)
    conclusion = "Its Hot";
else
    conclusion = "Its Very Hot";
Console.WriteLine(conclusion);


// Exercise 9

// example1
int numar1 = 10;
int numar2 = 15;
int mathOperations = (numar1 + numar2) - numar1 * 2 + (numar2 / 3);
Console.WriteLine(mathOperations);

// example2
Console.WriteLine("Type a number from 0 to 9.");
int input9 = Convert.ToInt32(Console.ReadLine());
if (input9 > 9)
{
    input9 -= input9;
    Console.WriteLine($"I told you to pick a number less than 9. Since you don't listen, I will now reduce you to {input9}!");
}

else if (input9 % 2 == 0)
    Console.WriteLine($"{input9} is an even number");
else if (input9 % 2 == 1)
{
    input9 += 1;
    Console.WriteLine($"Meh, I don't like odd numbers. Let's make it {input9}.");
}

// example3
List<int> myList1 = new List<int>();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Insert number: ");
    string myNumber = Console.ReadLine();
    int theNumber = Convert.ToInt32(myNumber);

    myList1.Add(theNumber);
}
Console.WriteLine();
foreach (int element in myList1)
{
    Console.WriteLine(element * 2);
}

// example4
List<int> myList2 = new List<int>();
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine("Insert number: ");
    string myNumber2 = Console.ReadLine();
    int theNumber2 = Convert.ToInt32(myNumber2);

    myList2.Add(theNumber2);
}
Console.WriteLine();
foreach (int element in myList2)
{
    Console.WriteLine(element / 2);
}

