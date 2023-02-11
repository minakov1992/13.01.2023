// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

void Generatematrix(int[,,] matrix)
{
    int[] temporary = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int num;
    for (int i = 0; i < temporary.GetLength(0); i++)
    {
        temporary[i] = new Random().Next(10, 100);
        num = temporary[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temporary[i] == temporary[j])
                {
                    temporary[i] = new Random().Next(10, 100);
                    j = 0;
                    num = temporary[i];
                }
                num = temporary[i];
            }
        }
    }
    int counter = 0;
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            for (int depth = 0; depth < matrix.GetLength(2); depth++)
            {
                matrix[rows, columns, depth] = temporary[counter];
                counter++;
            }
        }
    }
}

void Printmatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"  {matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива X rows Y rows Z:");
Console.Write("Введите X (длинна массива): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y (ширина массива): ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z (глубина массива): ");
int depth = Convert.ToInt32(Console.ReadLine());

if (rows > 0 && columns > 0 && depth > 0)
{
    Console.WriteLine();
    int[,,] array3D = new int[rows, columns, depth];
    Generatematrix(array3D);
    Printmatrix(array3D);
    Console.WriteLine();
}
else Console.WriteLine("Вводимые значения должны быть положительными.");