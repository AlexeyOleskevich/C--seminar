// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 1000);
int secondNumber = GetSecondNumber(num);

Console.Write(num + " -> " + secondNumber);

int GetSecondNumber(int number)
{
    return (number / 10) % 10;
}