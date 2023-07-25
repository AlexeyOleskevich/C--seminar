// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7->такого элемента в массиве нет

Console.Write("Input first dimension position: ");
int firstDimPos = int.Parse(Console.ReadLine());
Console.Write("Input second dimension position: ");
int secondDimPos = int.Parse(Console.ReadLine());

int firstDimension = 3, secondDimension = 3;
int min = -10, max = 10;

int[,] array2d = CreateMatrixRndInt(firstDimension, secondDimension, min, max);
PrintMatrix(array2d);

bool isValidPos = IsValidMatrixPosition(firstDimPos, secondDimPos, array2d);
if (!isValidPos) Console.Write("Element does not exists");
else
{
    int element = GetMatrixElementByPosition(firstDimPos, secondDimPos, array2d);
    Console.Write($"Element by indexes {firstDimPos} and {secondDimPos} is {element}");
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]    ");
    }
}

int GetMatrixElementByPosition(int row, int column, int[,] matrix) => matrix[row, column];

bool IsValidMatrixPosition(int row, int column, int[,] matrix) => row < matrix.GetLength(0) && row > 0
                                                               && column < matrix.GetLength(1) && column > 0;


