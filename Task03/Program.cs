// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("ENTER NUMBER");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Monday");
}
else if (day == "2")
{
    Console.WriteLine("Tuersday");
}
else if (day == "3")
{
    Console.WriteLine("Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("Thuersday");
}
else if (day == "5")
{
    Console.WriteLine("Friday");
}
else if (day == "6")
{
    Console.WriteLine("Saturday");
}
else if (day == "7")
{
    Console.WriteLine("Sunday");
}