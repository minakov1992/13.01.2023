// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int pal = 0, num = number;
// while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}
// Console.WriteLine(num == pal ? "Палиндром" : "Не палиндром");


void palindrom()
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;

    if (nul < 1 || nul > 9)
    {
        Console.WriteLine(number + " -> " + "Не пятизначное число");
    }
    else if (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine(number + " -> Палиндром");
    }
    else
    {
        Console.WriteLine(number + " -> Не палиндром");
    }
}
for (int i = 0; i < 10; i++)
{
    palindrom();
}