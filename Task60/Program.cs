// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

void GenerateArray3D(int[,,] array3D)
{
    int[] temporary = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
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
    for (int rows = 0; rows < array3D.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array3D.GetLength(1); columns++)
        {
            for (int depth = 0; depth < array3D.GetLength(2); depth++)
            {
                array3D[rows, columns, depth] = temporary[counter];
                counter++;
            }
        }
    }
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"  {array3D[i, j, k]}({i},{j},{k}) ");
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
Console.WriteLine();

int[,,] array3D = new int[rows, columns, depth];
GenerateArray3D(array3D);
PrintArray3D(array3D);
Console.WriteLine();