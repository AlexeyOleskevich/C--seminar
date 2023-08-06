// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

Console.WriteLine("Введите число m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (m1 < 0 || n1 < 0)
{
    Console.Write("Ошибка ввода");
    return;
}

int ackerman = ack(m1, n1);
Console.Write("Значение функции Аккермана: " + ackerman);

int ack(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = ack(m, n - 1);
        m--;
    }
    return n + 1;
}