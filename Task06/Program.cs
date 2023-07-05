// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

string answer = number % 2 == 0 ? "Yes" : "No";
Console.Write(answer);