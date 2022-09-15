/*
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.

void ShowNums(int m, int n)
{
    if (m <= n)
    {
        if (n > m) ShowNums(m, n - 1);
        Console.Write(n + " ");
    }
    else
    {
        if (n < m) ShowNums(m - 1, n);
        Console.Write(m + " ");
    }
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);
Console.WriteLine();
 */


/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

int GetSum(int m, int n)
{
    if (m <= n)
        if (n > m) return GetSum(m, n - 1) + n;
        else return n;
    else
        if (n < m) return GetSum(m - 1, n) + m;
        else return m;
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSum(m, n));
 */


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

ulong? AckermannFunction(int m, int n)
{
    if (m < 0 && n < 0)
    {
        Console.WriteLine("Unable to calculate Ackermann function, m < 0 and n < 0.");
        return null;
    }
    else if (m < 0)
    {
        Console.WriteLine("Unable to calculate Ackermann function, m < 0.");
        return null;
    }
    else if (n < 0)
    {
        Console.WriteLine("Unable to calculate Ackermann function, n < 0.");
        return null;
    }
    else if (m == 3 && n > 24 && n < 61)
    {
        return Convert.ToUInt64(Math.Pow(2, n + 3)) - Convert.ToUInt64(3);
    }
    else if (m == 3 && n > 60 || m == 4 && n > 1 || m == 5 && n > 0)
    {
        Console.WriteLine("Unable to calculate Ackermann function, not enough memory.");
        return null;
    }

    int rows = 1;
    int columns = 1;

    if (m > 0) rows = m + 1;
    if (n > 0) columns += n;

    if (m > 3)
        columns = Convert.ToInt32(Math.Pow(2, 17));
    else
        columns = Convert.ToInt32(Math.Pow(2, rows + columns));

    int[,] cacheArray = new int[rows, columns];

    return Convert.ToUInt64(AckermannFunctionRecursion(m, n, cacheArray));
}

int AckermannFunctionRecursion(int m, int n, int[,] cacheArray)
{
    if (m > 0 && n > 0)
    {
        if (cacheArray[m, n] == 0)
            if (m == 3 && n > 14)
                cacheArray[m, n] = Convert.ToInt32(Math.Pow(2, n + 3) - 3);
            else
                cacheArray[m, n] = AckermannFunctionRecursion(
                    m: m - 1,
                    n: AckermannFunctionRecursion(m, n - 1, cacheArray),
                    cacheArray);

        return cacheArray[m, n];
    }
    else if (m == 0)
        return n + 1;
    else
    {
        if (cacheArray[m, n] == 0)
            cacheArray[m, n] = AckermannFunctionRecursion(m - 1, 1, cacheArray);

        return cacheArray[m, n];
    }
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

ulong? result = AckermannFunction(m, n);
if (result is not null)
    Console.WriteLine($"A({m}, {n}) = {result:n0}");
