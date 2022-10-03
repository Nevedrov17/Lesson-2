void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void    PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while(possition< count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);