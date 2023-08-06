// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n1 = Convert.ToInt32(Console.ReadLine());

NaturalNumbersOnRange(m1, n1);

void NaturalNumbersOnRange(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbersOnRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbersOnRange(m + 1, n);

    }
    else Console.Write(m);
}