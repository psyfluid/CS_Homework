/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

double[,] CreateRandom2dArrayOfRealNumbers(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) +
                new Random().NextDouble();

    return newArray;
}

void Print2dArrayOfRealNumbers(double[,] array, int roundDigits = 15)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], roundDigits) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArrayOfRealNumbers(m, n, min, max);
Print2dArrayOfRealNumbers(myArray, 2);
 */


/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Print2dArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintElementByIndex(int[,] array, int row, int column)
{
    if (row >= array.GetLength(0))
        Console.WriteLine("There is no such element. "
            + $"Index of the row {row} is out of range");

    else if (column >= array.GetLength(1))
        Console.WriteLine("There is no such element. "
            + $"Index of the column {column} is out of range");

    else Console.WriteLine($"Element [{row}, {column}] = {array[row, column]}");
}

int? GetElementByIndex(int[,] array, int row, int column)
{
    if (row >= array.GetLength(0) || column >= array.GetLength(1))
        return null;
    else
        return array[row, column];
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Print2dArray(newArray);

Console.Write("Input index of the row: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index of the column: ");
int j = Convert.ToInt32(Console.ReadLine());

// Вариант 1. Только с выводом на печать
// PrintElementByIndex(newArray, i, j);

// Вариант 2. С возвратом значения
int? arrayElement = GetElementByIndex(newArray, i, j);
if (arrayElement is null)
    Console.WriteLine("There is no such element. Index out of range.");
else
    Console.WriteLine($"Element [{i}, {j}] = {arrayElement}");
 */



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArrayOfRealNumbers(double[] array, int roundDigits = 15)
{
    int i = 0;
    int len = array.Length;

    Console.WriteLine();
    while (i < len)
    {
        if (i == 0)
            Console.Write("[");
        Console.Write(Math.Round(array[i], roundDigits));
        if (i < len - 1)
            Console.Write(", ");
        else
            Console.Write("]");
        i++;
    }
    Console.WriteLine();
}

double[] FindMeanByColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] mean = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
            sum += array[i, j];
        mean[j] = sum / rows;
    }

    return mean;
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Print2dArray(newArray);

double[] arrayMean = FindMeanByColumns(newArray);
PrintArrayOfRealNumbers(arrayMean, 2);
