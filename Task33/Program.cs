// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да

int min = -100;
int max = 100;

int size = new Random().Next(2, 11);
int[] array = CreateArrayRndInt(size, min, max);

PrintArray(array);

Console.Write("Введите число для поиска в массиве: ");

int trgt = int.Parse(Console.ReadLine());

bool result = HasTarget(array, trgt);

Console.Write(result ? "Да" : "Нет");

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
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

bool HasTarget(int[] arr, int target)
{
    foreach (int element in arr)
    {
        if (element == target) return true;
    }
    return false;
}
