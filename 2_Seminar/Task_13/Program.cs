Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 == 0)
{
    Console.Write("Третьей цифры нет");
}
if (num >= 100 && num <= 999)
{
    Console.WriteLine(num + " -> " + num % 10);
}
if (num >= 1000)
{
    int workingNumber = num;
    workingNumber /= 100;
    Console.WriteLine(num + " -> " + workingNumber % 10);
}