// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
Console.Write($"max = {max}");
