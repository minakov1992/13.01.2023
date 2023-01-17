// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// int firstDigit = number / 100;
// int secondDigit = number % 10;
// int num = (firstDigit*10) + secondDigit;
// Console.WriteLine($"Из числа {number} получили {num}");

int number = new Random().Next(100, 1000);
int FirstThirdDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int res = (firstDigit*10) + secondDigit;
    return res;
}
int result = FirstThirdDigit(number);
Console.WriteLine($"Из числа {number} получили {result}");
