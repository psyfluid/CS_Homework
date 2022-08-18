/*
// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}
 */


/*
// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Input number a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number c ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");
 */


/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}
 */


// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());

int counter = 2;

while (counter <= n)
{
    Console.Write(counter + " ");
    counter += 2;
}

Console.WriteLine();
