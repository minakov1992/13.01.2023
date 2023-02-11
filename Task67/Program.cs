// Задача 67: Напишите программу,
// которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int SumDigits(int num)
{
    return num == 0 ? 0 : (num % 10) + SumDigits(num / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);
Console.WriteLine(result);