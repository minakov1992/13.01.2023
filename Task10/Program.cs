// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение 1.
// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = number / 10 % 10;
// Console.WriteLine($"из числа {number} получили {secondDigit}");


// Решение 2.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}
int secondDigit = SecondDigit(number);
Console.WriteLine($"из числа {number} получили {secondDigit}");