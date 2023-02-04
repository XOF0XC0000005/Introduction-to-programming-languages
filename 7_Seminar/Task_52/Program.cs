// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);
Average(array);

void Average(int[,] arr)
{
    double averageInColumn = 0;
    string result = "\nСреднее арифметическое каждого столбца: ";

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            averageInColumn += arr[i, j];
        }
        result +=  Math.Round(averageInColumn/row, 2) + "; ";
        averageInColumn = 0;
    }
    Console.WriteLine(result);
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