// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

if (k1 - k2 == 0) Console.Write("Прямые не пересекаются");
else
{
    string intersectionPoint = GetIntersectionPoint(b1, k1, b2, k2);
    Console.Write($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2}:      {intersectionPoint}");
}

string GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"({x},{y})";

}

