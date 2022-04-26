// 7. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(0, 201);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

int IsItThere(int[] array, int min, int max)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] >= min & array[i] <= max) count++;
    }
    return count;
}

int[] myArray = new int[123];
FillArray(myArray);
PrintArray(myArray);
int result = IsItThere(myArray, 10, 99);
Console.WriteLine($"Count = {result}");