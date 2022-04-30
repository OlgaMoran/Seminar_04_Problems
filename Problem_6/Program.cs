// 6. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных/четных чисел.

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(100, 1000);
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

int[] Array = new int[10];
FillArray(Array);
PrintArray(Array);

int x = Array.Length;
int odd = 0;
int even = 0;
for (int i = 0; i < x; i++)
{
    if (Array[i] % 2 == 0) even++;
    else odd++;    
}
Console.WriteLine($"even: {even}, odd: {odd}");