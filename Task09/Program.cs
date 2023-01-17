// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int numberFirst = number / 10;
// int numberSecond = number % 10;

// if(numberFirst > numberSecond)
//     Console.WriteLine($"Наибольшая цифра числа => {numberFirst}");
// else
//     Console.WriteLine($"Наибольшая цифра числа => {numberSecond}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int num)
{
    int numberFirst = num / 10;
    int numberSecond = num % 10;
    if(numberFirst > numberSecond) return numberFirst;
    else return numberSecond;
}
