// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int min = 100;
int max = 999;

int size = 10;
int[] array = CreateArrayRndInt(size, min, max);

PrintArray(array);

int result = GetEvenAmount(array);
Console.Write($"Количество четных чисел в массиве = {result}");

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

int GetEvenAmount(int[] arr)
{
    int evenAmount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (IsEvenNumber(arr[i])) evenAmount++;
    }
    return evenAmount;
}

bool IsEvenNumber(int number)
{
    return number % 2 == 0;
}
