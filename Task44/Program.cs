// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
if (n < 2) Console.Write("Ошибка ввода");

PrintArray(Fibonacci(n));

int[] Fibonacci(int number)
{
    int[] fibonacci = new int[number];
    fibonacci[1] = 1;
    for (int i = 2; i < fibonacci.Length; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
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