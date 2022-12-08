// Bubble sort algorithm

List<int> myList = new List<int> { 1, 9, 5, 6, 3, 2, 7 };
int temp;

for (int i = 0; i < myList.Count - 1; i++)
{
    for (int j = 0; j < myList.Count - 1; j++)
    {
        if (myList[j] > myList[j+1])
        {
            temp = myList[j + 1];
            myList[j + 1] = myList[j];
            myList[j] = temp;
        }
    }
}

foreach (int elem in myList)
    Console.WriteLine(elem);

 