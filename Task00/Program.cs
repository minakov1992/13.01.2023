// 0. Демонстрация решения
// Напишите программу, которая
// 1. на вход принимает число 
// 2. cвыдаёт его квадрат (число умноженное на само себя).
// 3. вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Enter Full Number");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");