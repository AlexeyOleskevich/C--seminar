// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int firstDimension = 3, secondDimension = 3;
int min = -10, max = 10;

double[,] array2d = CreateMatrixRndDouble(firstDimension, secondDimension, min, max);
PrintMatrix(array2d);

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = GenerateRandomDouble(random, min, max);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7}");
        }
        Console.WriteLine("  |");
    }
}

double GenerateRandomDouble(Random rnd, int min, int max, int round = 2)
{
    double randomDouble = rnd.NextDouble() * (max - min) + min;
    return Math.Round(randomDouble, round, MidpointRounding.ToZero);
}