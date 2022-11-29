// Exercitiu 1

using System.Linq.Expressions;

int[] myArray = new int[] { 1, 2, 3, 4, 5 };
int total = 0;
foreach (int elem in myArray)
{
    if (elem % 2 == 0)
    {
        total += elem;
    }
}
Console.WriteLine(total);



// Exercitiu 2
Console.WriteLine();

int[] myArray1 = new int[] { 1, 2, 3, 3, 4 };
for (int i = 0; i < myArray1.Length; i++)
{
    for (int j = i + 1; j < myArray1.Length; j++)
    {
        if (myArray1[i] == myArray1[j])
        {
            Console.WriteLine(myArray1[i]);
        }
    }
}



// Exercitiu 3
Console.WriteLine();

List<string> myList = new List<string> { "a", "b", "b", "c", "c", "c", "d" };
for (int m = 0; m < myList.Count; m++)
{
    for (int n = m + 1; n < myList.Count; n++)
    {
        if (myList[m] == myList[n])
        {
            myList.RemoveAt(m);
        }
    }
}
foreach (string elem in myList)
    Console.WriteLine(elem);



// Exercitiu 4    ---------------------Nu stiu cum sa evit in output repetarea rezultatului pentru fiecare element in parte :(--------------------
Console.WriteLine();

int[] myArray2 = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
foreach (int number in myArray2)
{
    int count = 0;
    for (int x = 0; x < myArray2.Length; x++)
    {
        if (number == myArray2[x])
            count += 1;
    }
    Console.WriteLine($"The frequency of {number} is {count}.");
}



// Exercitiu 5
Console.WriteLine();

int[] myArray3 = new int[6];
List<int> even = new List<int>();
List<int> odd = new List<int>();

for (int z = 0; z < 6; z++)
{
    Console.WriteLine("Insert number: ");
    int input = Convert.ToInt32(Console.ReadLine());
    myArray3[z] = input;
   }

foreach (int number in myArray3)
    if (number % 2 == 0)
    {
        even.Add(number);
    }
    else if (number % 2 != 0)
    {
        odd.Add(number);
    }

int[] evenArray = even.ToArray();
int[] oddArray = odd.ToArray();

foreach (int element in evenArray)
    Console.WriteLine($"{element} is even.");
foreach (int element in oddArray)
    Console.WriteLine($"{element} is odd.");