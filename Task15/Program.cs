// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (ValidateDay(number))
{
    bool isWeekend = IsWeekend(number);
    Console.Write(isWeekend ? "Да" : "Нет");
}
else Console.Write("Wrong input");

bool ValidateDay(int day)
{
    return day > 0 && day < 8;
}
bool IsWeekend(int day)
{
    return day == 6 || day == 7;
}
