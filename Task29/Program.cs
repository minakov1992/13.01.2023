// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void GenerateArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (res == String.Empty) res += array[i];
        else res += $", {array[i]}";
    }
    return res;
}

int[] result = new int[8];
GenerateArray(result, 0, 100);
Console.WriteLine($"{PrintArray(result)} -> [{PrintArray(result)}]");