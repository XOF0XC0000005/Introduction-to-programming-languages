Console.WriteLine("Сколько элементов добавить в массив?");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В каком диапозоне будут числа?(Введите в формате 0, 100)");
string[] numberRange = Console.ReadLine().Split(",");

int[] myArray = SetArray(length, numberRange);
PrintArray(myArray);

int[] SetArray(int length, string[] range)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(Convert.ToInt32(range[0]), Convert.ToInt32(range[1]) + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.Write("]");
}

