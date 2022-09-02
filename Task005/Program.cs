// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
string[,] spiral = new string[4, 4];
int number = 1;
for (int j = 0; j < spiral.GetLength(1); j++)
{
    int i = 0;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int i = 1; i < spiral.GetLength(0); i++)
{
    int j = 3;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int j = 2; j > 0; j--)
{
    int i = 3;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int i = 3; i > 0; i--)
{
    int j = 0;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int j = 1; j < spiral.GetLength(1)-1; j++)
{
    int i = 1;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int j = 2; j > 0; j--)
{
    int i = 2;
    if (number < 10)
    {
        spiral[i, j] = "0" + number;
        number++;
    }
    else
    {
        spiral[i, j] = $"{number}";
        number++;
    }
}
for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        Console.Write($"{spiral[i, j]} ");
    }
    Console.WriteLine();
}