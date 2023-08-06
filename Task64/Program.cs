// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.Write("Ошибка ввода");
else PrintNaturalNums(num);

void PrintNaturalNums(int n)
{
    if (n == 0) return;
    Console.Write(n + " ");
    PrintNaturalNums(--n);
}
