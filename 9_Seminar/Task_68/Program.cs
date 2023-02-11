// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число N: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {secondNumber}, n = {firstNumber} -> A(m,n) = {AkkermanFunction(firstNumber, secondNumber)}");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}