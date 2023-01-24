Console.Write("Введите число А: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write(CustomPow(firstNum, secondNum));

int CustomPow(int num, int power)
{
    int result = num;

    for (int i = 1; i < power; i++)
    {
        result *= num;
    }

    return result;
}
