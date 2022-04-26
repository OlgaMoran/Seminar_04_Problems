// 5.1. Определить, присутствует ли в заданном массиве некоторое число.

// Уточнение от "заказчика": если нет элемента - показать «-1», если есть - "1".
// Примечание: поиск выполняется в конкретном массиве.

int IsItThere(int[] array, int find)
{
    int length = array.Length;
    int count = 0;
    for (int index = 0; index < length; index++)
    {
        if (array[index] == find)
        {
            count++;
            break;
        }
    }
    return count;
}

int[] myArray = { 10, 34, 9, 634, 28, 93, 74, 9, 399 };
int result = IsItThere(myArray, 28);
if (result == 0) Console.WriteLine("-1");
else Console.WriteLine("1");