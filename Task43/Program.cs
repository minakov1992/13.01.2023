// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

// double CrossPoints(double bc1, double kc1, double bc2, double kc2)
// {
//     double yc = 0;
//     double xc = 0;
//     double yc = kc2 * xc + bc2;
//     {
//         double xc = (bc2 - bc1) / (kc1 - kc2);
//         return xc;
//     }
//     return yc;
// }

// Console.Write("введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// // double x = (-b2 + b1) / (-k1 + k2);
// // double y = k2 * x + b2;

// // Console.Write($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

// double cross = CrossPoints(b1, k1, b2, k2);





double[,] value = new double[2, 2];
double[] crossXY = new double[2];

void InputPoints()
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значения для {i + 1}-го уравнения (y = k * x + b):");
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение b{i + 1}: ");
            else Console.Write($"Введите значение k{i + 1}: ");
            value[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Solution(double[,] value)
{
    crossXY[0] = (value[1, 0] - value[0, 0]) / (value[0, 1] - value[1, 1]); // x = (-b2 + b1) / (-k1 + k2);
    crossXY[1] = crossXY[0] * value[1, 1] + value[1, 0]; // y = k2 * x + b2;
    return crossXY;
}

void OutputCrossXY(double[,] value)
{
    if (value[0, 1] == value[1, 1] && value[0, 0] == value[1, 0])
    {
        Console.WriteLine($"Прямые совпадают.");
    }
    else if (value[0, 1] == value[1, 1] && value[0, 0] != value[1, 0])
    {
        Console.WriteLine($"Прямые параллельны.");
    }
    else
    {
        Solution(value);
        Console.WriteLine($"Точка пересечения прямых: ({crossXY[0]}, {crossXY[1]})");
    }
}

InputPoints();
OutputCrossXY(value);