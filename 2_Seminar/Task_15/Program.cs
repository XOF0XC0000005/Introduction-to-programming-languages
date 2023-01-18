//Просили сделать через функции
Console.Write("Введите день недели цифрой: ");
int num = Convert.ToInt32(Console.ReadLine());

WeekendCheck(num);

void WeekendCheck(int number)
{
    if (number <= 5 &&  number >= 1)
    {
        Console.WriteLine(number + " -> нет");
    }
    else if (number == 6 || number == 7)
    {
        Console.WriteLine(number + " -> да");
    } else {
        Console.WriteLine("Введите день недели!");
    }
}