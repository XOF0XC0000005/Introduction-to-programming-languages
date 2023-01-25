//Усложнение 
// 3, 5 = 3 * 3 * 3 * 3 * 3 = (3 + 3 + 3) = (9 + 9 + 9) = (27 + 27 + 27) = (81 + 81 + 81)
Console.Write("Введите число А: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write($"{firstNum}, {secondNum} -> {CustomPowWithoutMultiply(firstNum, secondNum)}");

int CustomPowWithoutMultiply(int num, int pow)
{
    int count = num;
    int result = num;

    for (int i = 1; i < pow; i++)
    {
        for (int j = 1; j < count; j++)
        {
            result += num;
        }
        num = result;
    }
    return num;
}
//Домашка
// Console.Write("Введите число А: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{firstNum}, {secondNum} -> {CustomPow(firstNum, secondNum)}");

// int CustomPow(int num, int power)
// {
//     int result = num;

//     for (int i = 1; i < power; i++)
//     {
//         result *= num;
//     }

//     return result;
// }
