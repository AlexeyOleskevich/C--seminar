// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());

int factorial = Factorial(number);
Console.Write($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
    if (num == 0) return 1;
    return Factorial(num - 1) * num;
}