// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента, который вы хотите найти в формате 1 1 или 2 3: ");
string[] position = Console.ReadLine().Split(" ");
int rowPos = 0;
int colPos = 0;
int[,] array = new int[row, col];
bool success = int.TryParse(position[0], out rowPos) && int.TryParse(position[1], out colPos);

if (success)
{
    FillArray(array);
    PrintArray(array);
    FindElement(rowPos, colPos, array);
}
else
{
    Console.Write("Введите числа!");
    return;
}

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 21);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
    }
}

void FindElement(int row, int col, int[,] array)
{
    try
    {
        Console.Write($"\n{row} {col} -> {array[row, col]}");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.Write($"\n{row} {col} -> такого числа нет");
    }
}