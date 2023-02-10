// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// int[,] GenerateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max - 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],5} | ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangePositions(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temporary = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temporary;
//     }
// }

// int[,] array2D = GenerateMatrixRndInt(3, 4, 0, 10);
// Console.WriteLine($"До перемены строк - \n{PrintMatrix(array2D)}");
// PrintMatrix(array2D);
// ChangePositions(array2D);
// Console.WriteLine($"После перемены строк - \n{PrintMatrix(array2D)}");

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

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;

}

void ChangeRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temporary = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temporary;
    }
}

int[,] matrixNumbers = GenerateMatrix(3, 4, -10, 10);
Console.WriteLine($"До перемены строк - \n{PrintMatrix(matrixNumbers)}");

ChangeRows(matrixNumbers);
Console.WriteLine($"После перемены строк - \n{PrintMatrix(matrixNumbers)}");