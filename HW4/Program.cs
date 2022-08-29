/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

double ComputePower(double num, int power)
{
    double result = num;
    for (int i = 2; i <= power; i++)
        result *= num;

    return result;
}

Console.Write("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень, в которую нужно возвести число A: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} равно "
    + $"{Math.Round(ComputePower(a, b), 5)}");
 */


/*
// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

int ComputeSumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {n} равняется "
    + $"{ComputeSumOfDigits(n)}");
 */



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

int[] CreateArrayFromInput()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

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

PrintArray(CreateArrayFromInput());
