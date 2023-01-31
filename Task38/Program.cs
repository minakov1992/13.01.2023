// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] RandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("Массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

double[] MinMaxValue(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
        if (array[i] < minValue) minValue = array[i];
    }
    return new double[] { minValue, maxValue , maxValue - minValue};
}

double[] array = RandomArray(5, 0, 100);
PrintArray(array);

double[] result = MinMaxValue(array);
Console.WriteLine($"Минимальное значение в массиве: {result[0]}");
Console.WriteLine($"Максимальное значение в массиве: {result[1]}");
Console.WriteLine($"Разница максимального и минимального значений в массиве: {result[1]} - {result[0]} = {Math.Round((result[2]), 1)}");