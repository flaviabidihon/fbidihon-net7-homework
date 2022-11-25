// Exercitiu 2

int[,] myArray = new int[4, 3]
{
    {123, 345, 567},
    {12, 56, -12},
    {34, -98, 65},
    {765, 543, 321},
};
Console.WriteLine(myArray[1, 1] + ", " + myArray[2, 1]);


// Exercitiu 3
Console.WriteLine();

List<string> myList = new List<string>() { "MARIA", "DANA", "IOANA", "VIOLETA" };
Console.WriteLine("Insert name: ");
string input = Console.ReadLine().ToUpper();
if (myList.Contains(input))
{
    Console.WriteLine($"{input} is part of the list.");
}
else
{
    myList.Add(input);
    Console.WriteLine($"The name {input} was not part of the list. Now it has been added.");
    foreach (string item in myList)
        Console.WriteLine(item);
}


// Exercitiu 4
Console.WriteLine();

Stack<int> myStack = new Stack<int>();
Console.WriteLine("Insert first number.");
int input1 = Convert.ToInt32(Console.ReadLine());
myStack.Push(input1);
Console.WriteLine("Insert second number.");
int input2 = Convert.ToInt32(Console.ReadLine());
myStack.Push(input2);

if (input1 == 30 || input2 == 30 || (input1 + input2) == 30)
    Console.WriteLine("true");
else
    Console.WriteLine("false");


// Exercitiu 5
Console.WriteLine();

Queue<int> myQueue = new Queue<int>();

int input3;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Insert number");
    input3 = Convert.ToInt32(Console.ReadLine());
    myQueue.Enqueue(input3);
}

int top = myQueue.Peek();
if (top > 0 && top % 3 == 0 || top % 7 == 0)
    Console.WriteLine("The top of the queue, which is {0}, is a positive number and a multiple of 3 or a multiple of 7.", top);
else
{
    myQueue.Dequeue();
    Console.WriteLine("The top of the queue, which is {0}, is NOT a positive number, NEITHER a multiple of 3 or a multiple of 7. It has just been removed.", top);
    Console.WriteLine("The new top of the queue is {0}.", myQueue.Peek());
}

// Daca ar fi sa adaugam numrele in queue unul cate unul, putem face asa:

//Console.WriteLine("Insert first number: ");
//int input3 = Convert.ToInt32(Console.ReadLine());
//myQueue.Enqueue(input3);

//Console.WriteLine("Insert second number: ");
//int input4 = Convert.ToInt32(Console.ReadLine());
//myQueue.Enqueue(input4);

//Console.WriteLine("Insert third number: ");
//int input5 = Convert.ToInt32(Console.ReadLine());
//myQueue.Enqueue(input5);

//Console.WriteLine("Insert forth number: ");
//int input6 = Convert.ToInt32(Console.ReadLine());
//myQueue.Enqueue(input6);

//Console.WriteLine("Insert fifth number: ");
//int input7 = Convert.ToInt32(Console.ReadLine());
//myQueue.Enqueue(input7);


