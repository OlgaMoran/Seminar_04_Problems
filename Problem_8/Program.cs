// 8. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(0, 6);
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

int[] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);

int x = myArray.Length;
int sum = 0;
for (int pos = 1; pos < x; pos = pos + 2) sum = sum + myArray[pos];
Console.WriteLine($"Sum: {sum}");
