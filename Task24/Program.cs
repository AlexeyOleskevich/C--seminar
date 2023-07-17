// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите положительное число > 1: ");
int number = int.Parse(Console.ReadLine());

if (number > 1)
{
    long sum = GetSum(number);
    Console.Write(sum);
}
else Console.Write("Ошибка ввода");

long GetSum(int num)
{
    long sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}