// 5.2. Определить, присутствует ли в заданном массиве некоторое число.

// Уточнение от "заказчика": если нет элемента - показать «-1», если есть - "1".
// Примечание: поиск выполняется в массиве, созданным с помощью метода.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IsItThere(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] myArray = new int[10];

FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();

int pos = IsItThere(myArray, 3);
if (pos == 0)
{
    Console.WriteLine("-1");
}
else Console.WriteLine("1");