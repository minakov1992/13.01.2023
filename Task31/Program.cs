// Задача 31:
// 1. Задайте массив из 12 элементов,
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// int GetSumNegativeElements(int[] array)
// {
//     int sum = default;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sum += array[i];
//     }
//     return sum;
// }

// int GetSumPositiveElements(int[] array)
// {
//     int sum = default;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum += array[i];
//     }
//     return sum;
// }

int[] GetSumNegPosElements(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
        if (array[i] < 0) sumNeg += array[i];
    }
    return new int[] { sumPos, sumNeg, };
}



int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
// int sumNegativeElements = GetSumNegativeElements(arr);
// int sumPositiveElements = GetSumPositiveElements(arr);
// Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElements}");
// Console.WriteLine($"Сумма отрицательных элементов равна {sumNegativeElements}");

int[] sumNegPos = GetSumNegPosElements(arr);
Console.WriteLine($"Сумма положительных элементов равна {sumNegPos[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegPos[1]}");