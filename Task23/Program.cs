// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Введённое число не является натуральным");
else TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} | {count * count * count}");
        count++;
    }
}