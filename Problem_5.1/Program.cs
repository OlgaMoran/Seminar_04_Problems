// 5. Определить, присутствует ли в заданном массиве некоторое число.

// Уточнение от "заказчика": если нет элемента - показать «-1».

//int[] myArray = { 159, 38, 91, 6, 27, 114, 74, 6, 399 };
//int length = myArray.Length;

// string searchNum(int[] Array, int find)
// {
// int Length = Array.Length;
// int index = 0;
// while (index < Length)
// {
//     if (Array[index] == find)
//     {
//         int result = 1;
//         break;
//     }
//     index++;
// }
// return result; 
// }

// string res = searchNum(myArray, 6);

int[] array = { 10, 34, 9, 634, 28, 93, 74, 9, 399 };
int n = array.Length;
int find = 9;
int index = 0;
int count = 0;

while (index < n)
{
    if (array[index] == find)
    {
        count++;
        index++;
    }
}
if (count == 0)
{
    Console.WriteLine("No!");
}
else Console.WriteLine("YES!");
