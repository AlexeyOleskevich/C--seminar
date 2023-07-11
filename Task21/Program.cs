// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A(3, 6, 8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance(x1, x2, y1, y2, z1, z2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);

Console.Write("Расстояние между A и B: " + distRound);

double GetDistance(int xCoordinateA, int xCoordinateB, int yCoordinateA, int yCoordinateB, int zCoordinateA, int zCoordinateB)
{
    double xDifference = xCoordinateB - xCoordinateA;
    double yDifference = yCoordinateB - yCoordinateA;
    double zDifference = zCoordinateB - zCoordinateA;

    double distance = Math.Sqrt(xDifference * xDifference + yDifference * yDifference + zDifference * zDifference);
    return distance;
}