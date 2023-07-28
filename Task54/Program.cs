// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void InsertionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int pos = i;
        int max = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                pos = j;
                max = array[j];
            }
        }
        array[pos] = array[i];
        array[i] = max;
    }
}

void SortMatrixRowsDesc(int[,] matrix)
{
    int[] row;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        row = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        InsertionSort(row);
        for (int k = 0; k < row.Length; k++)
        {
            matrix[i, k] = row[k];
        }
    }
}

int[,] array2d = CreateMatrixyRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
SortMatrixRowsDesc(array2d);
PrintMatrix(array2d);
