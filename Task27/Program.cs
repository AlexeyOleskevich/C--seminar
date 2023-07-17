// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int absNumber = number;
if (number < 0) absNumber = -number;

int sumOfDigits = GetDigitSum(absNumber);
Console.Write($"Сумма цифр числа {number} = {sumOfDigits}");

int GetDigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num /= 10;
        sum += digit;
    }
    return sum;
}