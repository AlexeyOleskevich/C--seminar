// 16.Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(firstNum, secondNum);
Console.Write(isSquare ? "Да" : "Нет");

bool IsSquare(int firstNumber, int secondNumber)
{
    return firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber;
}