/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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

void BubbleSort2dArrayByColumnsDesc(int[,] array)
{
    int columns = array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < columns - 1; j++)
            for (int k = 0; k < columns - j - 1; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Print2dArray(myArray);
BubbleSort2dArrayByColumnsDesc(myArray);
Print2dArray(myArray);
 */


/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int FindRowWithMinSum(int[,] array)
{
    int minRow = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];

        if (i == 0 || sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Print2dArray(myArray);

int minRow = FindRowWithMinSum(myArray);
Console.WriteLine("The row number with the minimum sum of elements is "
    + $"{minRow + 1} (index = {minRow}).");
 */


/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

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

int[,]? MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);

    if (columnsA != rowsB)
        {
        Console.WriteLine("Unable to calculate matrix product. \n"
            + "The number of columns in the first matrix is ​​not equal to "
            + "the number of rows in the second matrix.");
        return null;
        }

    int[,] matrixC = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
        for (int j = 0; j < columnsB; j++)
            for (int k = 0; k < columnsA; k++)
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];

    return matrixC;
}


Console.Write("Input number of rows in the first matrix: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in the first matrix: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows in the second matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in the second matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandom2dArray(i, j, min, max);
Print2dArray(matrix1);

int[,] matrix2 = CreateRandom2dArray(m, n, min, max);
Print2dArray(matrix2);

int[,]? matrix3 = MatrixMultiplication(matrix1, matrix2);
if (matrix3 is not null)
    Print2dArray(matrix3);
 */


/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.

int[,,] CreateRandom3dArrayWithUniqueNumbers(int rows, int columns, int depth,
    int minValue, int maxValue)
{
    int[,,] newArray = new int[rows, columns, depth];

    int numberOfElements = rows * columns * depth;
    HashSet<int> numbers = new HashSet<int>();

    Random randomGenerator = new Random();
    while (numbers.Count < numberOfElements)
        numbers.Add(randomGenerator.Next(minValue, maxValue));

    int num = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                newArray[i, j, k] = numbers.ElementAt(num);
                num++;
            }

    return newArray;
}

void Print3dArray(int[,,] array)
{
    Console.WriteLine();
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");

            Console.WriteLine();
            }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of layers: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArrayWithUniqueNumbers(
    rows: m, columns: n, depth: l, minValue: min, maxValue: max);
Print3dArray(myArray);
 */



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void Print2dArrayWithLeadingZero(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int num = array[i, j];
            if (num < 10) Console.Write($"0{num} ");
            else Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateSpiral2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    int i_first = 0;
    int i_last = rows - 1;
    int j_first = 0;
    int j_last = columns - 1;
    int turn = 0;
    int step = 0;
    int i = i_first;
    int j = j_first;

    for (int n = 1; n <= rows * columns; n++)
    {
        newArray[i, j] = n;

        if (i == i_first && j == j_first)
            step = 1;
        else if (i == i_last && j == j_last)
            step = -1;

        if (turn % 2 == 0)
            j += step;
        else
            i += step;

        if ((i == i_first && j == j_last)
            || (i == i_last && j == j_last)
            || (i == i_last && j == j_first)
            || (i == i_first && j == j_first))
        {
            turn += 1;
        }

        if (i == i_first && j == j_last && turn > 4 && turn % 4 != 0)
            j_first++;
        else if (i == i_last && j == j_last)
            i_first++;
        else if (i == i_last && j == j_first)
            j_last--;
        else if (i == i_first && j == j_first)
            i_last--;
    }

    return newArray;
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] spiralArray = CreateSpiral2dArray(m, n);
Print2dArrayWithLeadingZero(spiralArray);
