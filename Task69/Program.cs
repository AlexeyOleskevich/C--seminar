// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = int.Parse(Console.ReadLine());

int MyPow(int n, int degr)
{
    return degr == 0 ? 1 : n * MyPow(n, degr - 1);
}

Console.Write(MyPow(num, degree));