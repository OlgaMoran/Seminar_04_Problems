// 8. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(0, 5);
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

int[] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);

int x = myArray.Length;
int sum = 0;
for (int pos = 1; pos < x; pos = pos + 2) sum = sum + myArray[pos];
Console.WriteLine($"Sum: {sum}");
