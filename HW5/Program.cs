/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void PrintArray(int[] array)
{
    int i = 0;
    int len = array.Length;
    while (i < len)
    {
        if (i == 0)
            Console.Write("[");
        Console.Write(array[i]);
        if (i < len - 1)
            Console.Write(", ");
        else
            Console.Write("]");
        i++;
    }
    Console.WriteLine();
}

int CountEvenInArray(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}


Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, 100, 999);
PrintArray(myArray);

Console.WriteLine("The number of even numbers in the array is " +
    CountEvenInArray(myArray));
 */


/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void PrintArray(int[] array)
{
    int i = 0;
    int len = array.Length;
    while (i < len)
    {
        if (i == 0)
            Console.Write("[");
        Console.Write(array[i]);
        if (i < len - 1)
            Console.Write(", ");
        else
            Console.Write("]");
        i++;
    }
    Console.WriteLine();
}

int FindSumOfOddIndices(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

Console.WriteLine("The sum of elements with odd indices is " +
    FindSumOfOddIndices(myArray));
 */



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] CreateRandomArrayOfRealNumbers(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1) +
            new Random().NextDouble();

    return newArray;
}

void PrintArrayOfRealNumbers(double[] array, int roundDigits = 15)
{
    int i = 0;
    int len = array.Length;
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

double[] FindDifferenceBetweenMinAndMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    double[] result = {min, max, max - min};
    return result;
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArrayOfRealNumbers(size, min, max);
PrintArrayOfRealNumbers(myArray, 2);

double[] result = FindDifferenceBetweenMinAndMax(myArray);

Console.WriteLine($"Min element of the array is {Math.Round(result[0], 2)} \n" +
    $"Max element of the array is {Math.Round(result[1], 2)} \n" +
    "The difference between min and max elements of the array is " +
    Math.Round(result[2], 2));
