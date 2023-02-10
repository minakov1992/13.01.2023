// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

void GenerateMatrix(int[,] matrix)
{
  Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int min = 0; int max = 10;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
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

void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i,k] * matrixB [k,j];
      }
      matrixC[i,j] = sum;
    }
  }
}

Console.WriteLine("Введите размеры матриц:");
Console.Write("Число строк 1-й матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов 1-й матрицы и число строк 2-й матрицы): ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов 2-й матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[x, y];
GenerateMatrix(matrixA);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixA);

int[,] matrixB = new int[y, z];
GenerateMatrix(matrixB);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixB);

int[,] matrixC = new int[x,z];
MultiplyMatrix(matrixA, matrixB, matrixC);
Console.WriteLine("Произведение матриц:");
PrintMatrix(matrixC);