Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> {DigitsSum(num)}");

int DigitsSum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}