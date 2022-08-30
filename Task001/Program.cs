// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = array.GetLength(1) - 1; count > 0; count--)
        {
            for (int j = array.GetLength(1) - 1; j > 0; j--)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                }
            }
        }
    }
    ShowArray(array);
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
Console.WriteLine("Результат сортировки массива");
SortArray(array);
Console.WriteLine();