// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] NewArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumLine(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i, j];
        }
    }
    for (int i = 0; i < sum.Length; i++)
    {
        Console.WriteLine($"Сумма элементов {i + 1} строки = {sum[i]}");
    }
    int indexMin = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < sum[indexMin]) 
        {
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{indexMin+1} строка имеет наименьшую сумму элементов");
}

Console.Clear();
Console.Write("Введите количество строк и столбцов двумерного массива, я заполню его случайными числами и отсортирую в порядке убывания");
Console.WriteLine();
Console.WriteLine();
Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = NewArray(n, m);
Console.WriteLine("Сгенерированный массив");
ShowArray(array);
Console.WriteLine();
SumLine(array);
Console.WriteLine();