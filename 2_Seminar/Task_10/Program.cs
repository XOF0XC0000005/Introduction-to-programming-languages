Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int workingNumber = num;
workingNumber /= 10;
Console.Write(num + " -> " + workingNumber % 10);