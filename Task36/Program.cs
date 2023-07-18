// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int min = -10;
int max = 10;

int size = 6;
int[] array = CreateArrayRndInt(size, min, max);

PrintArray(array);

int sumElements = GetSumAtOddPosition(array);

Console.Write($"Сумма элементов, стоящих на нечетных позициях, равна {sumElements}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i == arr.Length - 1) break;
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

int GetSumAtOddPosition(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (IsOddNumber(i)) sum += arr[i];
    }
    return sum;
}

bool IsOddNumber(int number)
{
    return number % 2 != 0;
}