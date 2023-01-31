// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

bool IsItTriangle(int A, int B, int C)
{
    return A + B < C && A + C < B && B + C < A;
}

Console.WriteLine("Введите три числа: ");
int apex1 = Convert.ToInt32(Console.ReadLine());
int apex2 = Convert.ToInt32(Console.ReadLine());
int apex3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsItTriangle(apex1, apex2, apex3)? "нет" : "да");
