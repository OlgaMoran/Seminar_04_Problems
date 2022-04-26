// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных/четных чисел.

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(100, 1000);
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

int[] Array = new int[10];
FillArray(Array);
PrintArray(Array);

int x = Array.Length;
int i = 0;
int odd = 0;
int even = 0;
while (i < x)
{
    if (Array[i] % 2 == 0) even++;
    else odd++;
    i++;
}
Console.WriteLine($"even: {even}, odd: {odd}");