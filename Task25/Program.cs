// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int degree = int.Parse(Console.ReadLine());

if (IsNatural(degree))
{
    double result = Pow(number, degree);
    Console.Write($"{number}^{degree} = {result}");
}
else Console.Write("Введённая степень не является натуральной");


double Pow(double num, int degr)
{
    double power = 1;
    while (degr > 0)
    {
        power *= num;
        --degr;
    }
    return power;
}

bool IsNatural(int num)
{
    return num > 0;
}
