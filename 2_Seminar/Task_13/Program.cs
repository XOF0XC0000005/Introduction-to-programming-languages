Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int workingNumber = num;
if (workingNumber / 100 == 0)
{
    Console.Write("Третьей цифры нет");
}
if (workingNumber >= 100)
{
    while (workingNumber >= 999)
    {
        workingNumber = workingNumber / 10;
    }
    Console.WriteLine(num + " -> " + workingNumber % 10);
}