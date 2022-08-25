/*
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

// Универсальный метод для целых чисел int32 (меньше 2^31, ~ до 2 млрд.)
bool CheckPalindrome(int number)
{
    int divisor = 1_000_000_000;
    bool palindrome = false;
    while (divisor >= 10)
    {
        if (number / divisor == 0)
        {
            divisor /= 10;
            continue;
        }

        if (number / divisor == number % 10)
        {
            palindrome = true;
            number %= divisor;
            number /= 10;
            divisor /= 100;
        }
        else return false;
    }
    return palindrome;
}

Console.Write("Введите число для проверки, является ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = CheckPalindrome(num) ? "" : " не";
Console.WriteLine($"Число {num}{result} является палиндромом");
 */


/*
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

double FindDistance3D(double x1, double y1, double z1,
                    double x2, double y2, double z2)
{
    double distance_x = x2 - x1;
    double distance_y = y2 - y1;
    double distance_z = z2 - z1;

    double distance = Math.Sqrt(Math.Pow(distance_x, 2)
        + Math.Pow(distance_y, 2)
        + Math.Pow(distance_z, 2));
    return distance;
}

Console.Write("Введите координату X точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(FindDistance3D(xA, yA, zA, xB, yB, zB), 2);

Console.WriteLine($"Расстояние между точками A ({xA}, {yA}, {zA}) и "
    + $"B ({xB}, {yB}, {zB}) равняется {distance}");
 */



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.

void PrintCubes(int n)
{
    int counter = 1;
    while (counter <= n)
    {
        Console.Write(Math.Pow(counter, 3));
        if (counter < n) Console.Write(", ");
        else Console.WriteLine();
        counter++;
    }
}

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintCubes(num);
