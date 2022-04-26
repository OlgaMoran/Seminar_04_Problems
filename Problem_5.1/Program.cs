// 5.1. Определить, присутствует ли в заданном массиве некоторое число.

// Уточнение от "заказчика": если нет элемента - показать «-1».
// Примечание: поиск выполняется в конкретном массиве.

int IsItThere(int[] array, int find)
{
    int length = array.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
        if (array[index] == find)
        {
            count = index;
            break;
        }
        index++;
    }
    return count;
}

int[] myArray = { 10, 34, 9, 634, 28, 93, 74, 9, 399 };

int pos = IsItThere(myArray, 4);
if (pos == 0)
{
    Console.WriteLine("-1");
}
else Console.WriteLine("Found it!");