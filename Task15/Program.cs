// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if(dayNumber < 6)
// {
//     Console.WriteLine("Нет, это рабочий день");
// }
// else if (dayNumber < 1 || dayNumber > 7)
// {
//     Console.WriteLine("Ошибка, вы не ввели цифру, обозначающую день недели. Попробуйте ещё раз.");
// }
// else
// {
//     Console.WriteLine("Да, это выходной день");
// }

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void TheDayOfTheWeek (int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
    Console.WriteLine("Да, это выходной день");
  }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Ошибка, вы не ввели цифру, обозначающую день недели. Попробуйте ещё раз.");
    }
  else Console.WriteLine("Нет, это рабочий день");
}

TheDayOfTheWeek(dayNumber);