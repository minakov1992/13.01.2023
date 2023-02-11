// Задача 69: Напишите программу,
// которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int Exponentiation(int numA, int numB)
{
    return numB == 0 ? 1 : numA * Exponentiation(numA, numB - 1);
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
if (numberB <= 0)
    Console.WriteLine($"Число {numberB} не является натуральным числом");
else
    Console.WriteLine($"Число {numberA} в степени {numberB} -> {exponentiation}");

    