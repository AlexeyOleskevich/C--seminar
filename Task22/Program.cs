Console.WriteLine("Введите целое положительное число");

int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}  {count * count}");
        count++;

    }
}
