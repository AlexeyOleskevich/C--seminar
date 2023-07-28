// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

int[,,] CreateArray(int firstDim, int secondDim, int thirdDim)
{
    int[,,] array = new int[firstDim, secondDim, thirdDim];
    int twoDigitsNum = 10;
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                array[i, j, k] = twoDigitsNum++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

int firstDimension = 2;
int secondDimension = 2;
int thirdDimension = 2;
if (firstDimension * secondDimension * thirdDimension >= 100)
{
    throw new ArgumentException("Неверный размер массива");
}
int[,,] array3d = CreateArray(firstDimension, secondDimension, thirdDimension);
PrintArray(array3d);