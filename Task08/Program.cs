// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Input a positive number greater than 1: ");
int number = Convert.ToInt32(Console.ReadLine());

string answer = "";
if (number > 1)
{
    for (int i = 2; i <= number; i += 2)
    {
        answer += i + "";
        if (i >= number - 1) break;
        answer += ", ";
    }
}
else
{
    answer = "Wrong input!";
}
Console.Write(answer);