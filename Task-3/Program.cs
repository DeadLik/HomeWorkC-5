// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MinAndMaxValue(double[] arr)
{
    double max = 0;
    double min = 999;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    return max - min;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
Console.WriteLine($"Разница между максимальным и минимальным значением элемента = {MinAndMaxValue(array)}");
PrintArray(array);