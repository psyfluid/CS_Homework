/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.

int CountNumbers(int n)
{
    int count = 0;
    int temp = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Input number {i}: ");
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    return count;
}

Console.Write("Input the quantity of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The quantity of positive numbers is {CountNumbers(m)}");
 */



// Задача 43: Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void FindIntersectionOfLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("The lines are congruent.");
    else if (k1 == k2) Console.WriteLine("The lines are parallel.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("The coordinates of the point of intersection " +
            $"of the lines are ({x}; {y}).");
    }
}

Console.Write("Input the value of variable b1 in the equation " +
    "y = k1 * x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the value of variable k1 in the equation " +
    "y = k1 * x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the value of variable b2 in the equation " +
    "y = k2 * x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the value of variable k2 in the equation " +
    "y = k2 * x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindIntersectionOfLines(b1, k1, b2, k2);
