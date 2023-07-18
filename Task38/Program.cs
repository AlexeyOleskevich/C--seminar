// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int size = 5;
int min = -20;
int max = 20;
double[] array = CreateArrayRndDouble(size, min, max);

PrintArrayDouble(array);

double difference = GetDifferenceBetweenMaxAndMin(array);
Console.Write($"Разница между максимальным и минимальным элементами равна {difference}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = GenerateRandomDouble(min, max);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        double roundElement = Math.Round(arr[i], 2, MidpointRounding.ToZero);
        Console.Write(roundElement);

        if (i == arr.Length - 1) break;
        Console.Write("; ");
    }
    Console.WriteLine("]");
}

double GenerateRandomDouble(int min, int max, int round = 2)
{
    Random rnd = new Random();
    double randomDouble = rnd.NextDouble() * (max - min) + min;
    return Math.Round(randomDouble, round, MidpointRounding.ToZero);
}

double GetDifferenceBetweenMaxAndMin(double[] arr)
{
    double minimum = GetMin(arr), maximum = GetMax(arr);

    return maximum - minimum;
}

double GetMax(double[] arr)
{
    double maximum = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maximum) maximum = arr[i];
    }
    return maximum;
}

double GetMin(double[] arr)
{
    double minimum = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minimum) minimum = arr[i];

    }
    return minimum;
}