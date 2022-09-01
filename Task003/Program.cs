// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void ProductOfMatrices(int[,] a, int[,] b)
{
    int[,] product = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            product[i, j] = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                product[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    Console.WriteLine("Произведение матрицы А на В");
    ShowArray(product);
}

Console.Clear();
Console.Write("Данная программа находит произведение двух матриц");
Console.WriteLine();
Console.Write("Как вы знаете при умножении матрицы A на матрицу B должно выполняться условие равенства");
Console.WriteLine();
Console.Write("числа столбцов матрицы А и числа строк матрицы В");
Console.WriteLine();
Console.WriteLine();
Console.Write("Количество строк матрицы А: ");
int lineA = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов матрицы А и количество строк матрицы В: ");
int ColumnALineB = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов матрицы В: ");
int columnB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arrayA = NewArray(lineA, ColumnALineB);
int[,] arrayB = NewArray(ColumnALineB, columnB);
Console.WriteLine("Матрица А");
ShowArray(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица B");
ShowArray(arrayB);
Console.WriteLine();
ProductOfMatrices(arrayA, arrayB);
Console.WriteLine();