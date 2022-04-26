// 4. Написать программу замену элементов массива на противоположные

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(-50, 51);
        index++;
    }
}
void PrintArray(int[] Array)
{
    int count = Array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(Array[position]);
        position++;
    }
}

int[] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();

void Opposite(int[] Array)
{
    int x = Array.Length;
    for (int i = 0; i < x; i++) 
    {
        Array[i] = -Array[i];
    }
}

Opposite(myArray);
PrintArray(myArray);