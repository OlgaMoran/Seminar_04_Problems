// 3. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

// Уточнение от "заказчика": создать методы отдельно для поиска положительных 
// и отдельно для отрицательных).

void FillArray(int[] Array)
{
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(-10, 11);
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
int SumPos(int[] Array)
{
    int lengthPos = Array.Length;
    int sum = 0;
    for (int i = 0; i < lengthPos; i++)
    {
        if(Array[i] > 0) sum = sum + Array[i];
    }
    return sum;
}
int SumNeg(int[] Array)
{
    int lengthNeg = Array.Length;
    int sum = 0;
    for (int i = 0; i < lengthNeg; i++)
    {
        if(Array[i] < 0) sum = sum + Array[i];
    }
    return sum;
}

int[] myArray = new int[12];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine("sum of positive numbers: " + SumPos(myArray));
Console.WriteLine("sum of negative numbers: " + SumNeg(myArray));