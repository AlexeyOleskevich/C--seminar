// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(GetDigitsSum(num));

int GetDigitsSum(int n)
{

    if (n == 0) return n;
    return GetDigitsSum(n / 10) + n % 10;
}