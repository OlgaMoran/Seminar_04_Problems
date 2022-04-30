// 5.2. Определить, присутствует ли в заданном массиве некоторое число.

// Уточнение от "заказчика": если нет элемента - показать «-1», если есть - "1".
// Примечание: поиск выполняется в массиве, созданным с помощью метода.

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(1, 10);
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

int IsItThere(int[] array, int find)
{
    int count = array.Length;
    int pos = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] == find)
        {
            pos++;
            break;
        }
    }
    return pos;
}

int[] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();

int result = IsItThere(myArray, 5);
if (result == 0) Console.WriteLine("-1");
else Console.WriteLine("1");