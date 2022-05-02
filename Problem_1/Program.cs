// 1. Задать массив из 8 элементов и вывести их на экран. 
  
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

int[] myArray = new int[8];
FillArray(myArray);
PrintArray(myArray);