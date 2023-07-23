// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int amount = 5;

int positiveAmount = GetPositiveNumAmount(amount);
Console.Write("Количество положительных чисел: " + positiveAmount);

int GetPositiveNumAmount(int size)
{
    int positiveCounter = 0;
    while (size > 0)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0) positiveCounter++;
        size--;
    }
    return positiveCounter;
}