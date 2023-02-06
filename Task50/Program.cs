// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();

int[,] GenerateMatrixRndInt()
{
    int[,] matrix = new int[10, 10];
    Random rnd = new Random();
    int min = 0;
    int max = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
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
            Console.Write($"{matrix[i, j],5} | ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix)
{
    Console.Write("Bведите номер строки: ");
    int nRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int mColumns = Convert.ToInt32(Console.ReadLine());

    if (nRows > matrix.GetLength(0) || mColumns > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в матрице.");
    }
    else
    {
        Console.WriteLine($"Значение элемента {nRows} строки и {mColumns} столбца -> {matrix[nRows - 1, mColumns - 1]}");
    }
}

int[,] array2D = GenerateMatrixRndInt();
PrintMatrix(array2D);
FindElement(array2D);