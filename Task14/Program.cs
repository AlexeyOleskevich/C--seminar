// 14.Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool num = IsMultiplicity(number);
Console.WriteLine(num ? "Да" : "Нет");

bool IsMultiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

