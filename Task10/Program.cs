// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение 1.
// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number / 10 % 10;
// Console.WriteLine($"из числа {number} получили  result}");


// Решение 2.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int result = num / 10 % 10;
    return result;
}
int result = SecondDigit(number);
Console.WriteLine($"из числа {number} получили  {result}");