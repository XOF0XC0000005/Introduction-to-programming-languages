//Усложнение от Алексея
Console.Write("Введите число: ");
string stringNum = Console.ReadLine();
Console.Write("Какую цифру по счёту вам нужно вывести: ");
int findNum = Convert.ToInt32(Console.ReadLine());
if (findNum <= stringNum.Length)
{
    Console.WriteLine(stringNum + " -> " + stringNum[findNum - 1]);
}
else
{
    Console.WriteLine("Такого индекса нет в числе");
}
//По заданию
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int workingNumber = num;
// if (workingNumber / 100 == 0)
// {
//     Console.Write("Третьей цифры нет");
// }
// if (workingNumber >= 100)
// {
//     while (workingNumber >= 999)
//     {
//         workingNumber = workingNumber / 10;
//     }
//     Console.WriteLine(num + " -> " + workingNumber % 10);
// }