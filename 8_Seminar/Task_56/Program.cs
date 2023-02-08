// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
if(col == row)
{
    Console.Write("Введите не квадратную матрицу");
    return;
}
int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);
FindSmallestRow(array);

void FindSmallestRow(int[,] arr)
{
    int smallestSum = 0;
    int tempSmallest = 0;
    int row = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempSmallest += arr[i,j]; 
        }
        if(i == 0) smallestSum = tempSmallest;
        else if(smallestSum > tempSmallest)
        {
             smallestSum = tempSmallest;
             row = i + 1;
        }
        tempSmallest = 0;
    }
    Console.Write($"\n {smallestSum} = {row} строка");
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