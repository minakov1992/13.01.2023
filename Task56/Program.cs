// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int[] SumRow(int[,] matrix, int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int MinSumRow(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    return index + 1;
}


Console.Write("Введите размер прямоугольной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    Console.WriteLine();
    int[,] array2D = GenerateMatrix(size, size, 0, 10);
    Console.WriteLine("Случайная прямоугольная матрица:");
    PrintMatrix(array2D);
    int[] array = SumRow(array2D, size);
    Console.WriteLine("Сумма строк в массиве:");
    PrintArray(array);
    Console.WriteLine();
    int result = MinSumRow(array);
    Console.WriteLine("Номер строки с наименьшей суммой элементов в массиве: " + result);
}
else Console.WriteLine("Размер массива не может быть отрицательным");