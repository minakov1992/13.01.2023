// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNumbers(int num)
{
    int count = 0;
    if(num < 0) num = num * -1;

    while (num > 0)
    {
        num = num / 10;
        count ++;
    }
    return count;
}

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumbers(number);
Console.WriteLine($"В числе {number} -> {result} цифр");