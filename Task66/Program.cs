// Задача 66: Задайте значения numM и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от numM до N.
// Выполнить с помощью рекурсии.
// numM = 1; N = 15 -> 120
// numM = 4; N = 8. -> 30

Console.Clear();

int CountNaturalSunumberM(int m, int n)
{
    return n == m ? n : n + CountNaturalSunumberM(m, n - 1);
}

Console.Write("Введите число numM: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM > 0 && numN > 0)
{
    int result = CountNaturalSunumberM(numM, numN);
    Console.WriteLine($"Сумма элементов от {numM} до {numN} = {result}");
}
else
{
    Console.WriteLine("Некорректный ввод. Вы ввели отрицательное число.");
}
