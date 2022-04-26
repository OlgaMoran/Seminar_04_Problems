// 10. В указанном массиве вещественных чисел 
// найдите разницу между максимальным и минимальным элементом.

double MaxArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    double max = array[0];
    while (index < length)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;
}
double MinArray(double[] array)
{
    int count = array.Length;
    int position = 0;
    double min = array[0];
    while (position < count)
    {
        if (array[position] < min)
        {
            min = array[position];
        }
        position++;
    }
    return min;
}

double[] myArray = { 10.1, -34, 9.3, 6, -28 };
double Max = MaxArray(myArray);
double Min = MinArray(myArray);
double result = Max - Min;

Console.WriteLine(Max);
Console.WriteLine(Min);
Console.WriteLine();
Console.WriteLine(result);