// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (m1 < 0 || n1 < 0)
{
    Console.Write("Ошибка ввода");
    return;
}
int sum = n1 < m1 ? GetSumBetweenNums(n1, m1) : GetSumBetweenNums(m1, n1);
Console.Write($"Сумма: {sum}");

int GetSumBetweenNums(int m, int n)
{
    return m == n ? n : GetSumBetweenNums(m + 1, n) + m;
}