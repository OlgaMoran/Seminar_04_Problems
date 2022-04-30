// 7. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(0, 201);
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