// 2. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(0, 2);
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

int[] myArray = new int[8];
FillArray(myArray);
PrintArray(myArray);