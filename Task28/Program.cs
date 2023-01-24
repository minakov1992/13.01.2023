// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod *= i;
    }
    return prod;
}

Console.Write("Введите число: ");
int number =  Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int result = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равна {result}");
}
else
    Console.WriteLine("Введено некорректное значение");