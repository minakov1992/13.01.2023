﻿// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

void FillMatrix(int[,] matrix)
{
    int temp = 1; int i = 0; int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;
        temp++;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]}  ");
            else Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size > 0)
{
    int[,] matrix = new int[size, size];
    FillMatrix(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Вводимый размер матрицы должен быть положительнымю");