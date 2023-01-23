// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Cube(number);


void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} x {count} x {count} = {count * count * count}");
        count++;
    }
}