/*
// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit(int number)
{
    return number % 100 / 10;
}

Console.Write("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int digit2 = FindSecondDigit(num);
Console.WriteLine($"Вторая цифра числа {num}: {digit2}");
 */


/*
// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int FindThirdDigit(int number)
{
    if (number / 100 == 0)
        return -1;

    int lastDigit = 0;
    while (number / 100 > 0)
    {
        lastDigit = number % 10;
        number /= 10;
    }

    return lastDigit;
}

Console.Write("Введите целое число (меньше 2^31, ~ до 2 млрд.) ");
int num = Convert.ToInt32(Console.ReadLine());

int digit3 = FindThirdDigit(num);

if (digit3 == -1)
    Console.WriteLine($"У числа {num} нет третьей цифры.");
else
    Console.WriteLine($"Третья цифра числа {num}: {digit3}");
 */



// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckHoliday(int number)
{
    if (number == 6 | number == 7)
        Console.WriteLine("Это выходной? - Да");
    else
        Console.WriteLine("Это выходной? - Нет");
}

Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

CheckHoliday(day);
