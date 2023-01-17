// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int second = Convert.ToInt32(Console.ReadLine());
// int number = first % second;
// if (number == 0)
// {
//     Console.WriteLine($"{first} кратно {second}");
// }
// else
// {
//     Console.WriteLine($"Не кратно. Остаток от деления {first} на {second} равен {number}");
// }

int MultipleNum(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Введите два числа :");

int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());

int remains = MultipleNum(numberFirst, numberSecond);

if (remains == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, {remains} ");
}