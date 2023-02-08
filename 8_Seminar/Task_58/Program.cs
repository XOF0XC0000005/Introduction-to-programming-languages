// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите колличество строк матрицы А: ");
int rowA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов матрицы A: ");
int colA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк матрицы B: ");
int rowB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов матрицы B: ");
int colB = Convert.ToInt32(Console.ReadLine());
if (colA != rowB)
{
    Console.Write("Произведение двух матриц не имеет смысла");
    return;
}
int[,] arrayA = new int[rowA, colA];
int[,] arrayB = new int[rowB, colB];
FillArray(arrayA);
FillArray(arrayB);
PrintArray(arrayA);
PrintArray(arrayB);
FindProductionAB(arrayA, arrayB);

void FindProductionAB(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            arrayC[i,j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    PrintArray(arrayC);
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
    Console.WriteLine();
}