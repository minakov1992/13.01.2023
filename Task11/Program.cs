// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int secondDigit = number % 10;
int num = (firstDigit*10) + secondDigit;
Console.WriteLine($"Из числа {number} получили {num}");