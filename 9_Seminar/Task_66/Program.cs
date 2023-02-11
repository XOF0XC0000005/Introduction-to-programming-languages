// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberFrom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberTo = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numberFrom}; N = {numberTo} -> {SumElementsBetween(numberFrom, numberTo)}");

int SumElementsBetween(int from, int to)
{
    if(from == to) return from;
    return from + SumElementsBetween(from + 1, to);
}