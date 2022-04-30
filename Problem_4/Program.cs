// 4. Написать программу замену элементов массива на противоположные.

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int position = 0; position < count; position++)
    {
        Console.WriteLine(array[position]);
    }
}
void Opposite(int[] Array)
{
    int x = Array.Length;
    for (int i = 0; i < x; i++)
    {
        Array[i] = -Array[i];
    }
}

int[] myArray = new int[5];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Opposite(myArray);
PrintArray(myArray);