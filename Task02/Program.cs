// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
double numberB = Convert.ToInt32(Console.ReadLine());
double max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);