// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixyRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int aRows = matrixA.GetLength(0);
    int aCols = matrixA.GetLength(1);
    int bRows = matrixB.GetLength(0);
    int bCols = matrixB.GetLength(1);
    if (aCols != bRows)
    {
        throw new ArgumentException("Невозможно найти результат произведения матриц таких размерностей.");
    }

    int[,] result = new int[aRows, bCols];

    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bCols; ++j)
        {
            for (int k = 0; k < aCols; ++k)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return result;
}

int[,] firstMatrix = CreateMatrixyRndInt(3, 5, 0, 10);
int[,] secondMatrix = CreateMatrixyRndInt(4, 3, 0, 10);

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] productMatrix = MatrixProduct(firstMatrix, secondMatrix);
PrintMatrix(productMatrix);