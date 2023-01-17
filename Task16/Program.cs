// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("Enter number A");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA == numB * numB)
// {
//     Console.WriteLine($"{numA} является квадратом {numB}");
// }
// else if(numB == numA * numA)
// {
//     Console.WriteLine($"{numB} является квадратом {numA}");
// }
// else
// {
//     Console.WriteLine("Данные числа не являются квадратами друг друга");
// }

bool Square(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

if (result) Console.WriteLine("да");
else Console.WriteLine("нет");