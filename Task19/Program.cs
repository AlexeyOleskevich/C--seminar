// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;
if (IsFiveDigitNumber(number))
{
    bool isPalindrome = IsPalindrome(number);
    Console.Write(isPalindrome ? "Да" : "Нет");
}
else
{
    Console.Write("Введённое число не является пятизначным");
}

bool IsPalindrome(int num)
{
    int firstDigit = num / 10000 % 10;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num / 10 % 10;
    int fifthDigit = num % 10;

    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}

bool IsFiveDigitNumber(int num)
{
    return number >= 10000 && number <= 99999;
}

