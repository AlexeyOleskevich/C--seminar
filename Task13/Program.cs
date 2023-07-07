// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;

Console.Write(number < 100 ? "третьей цифры нет" : GetThirdNumber(number));

int GetThirdNumber(int num)
{
    while (num >= 1000)
    {
        num /= 10;
    }
    return num % 10;
}

