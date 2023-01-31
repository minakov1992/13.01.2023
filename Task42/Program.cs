// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();



string InverseNumbers(int num)
{
    string res = string.Empty;

    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = InverseNumbers(number);
Console.Write(result);
