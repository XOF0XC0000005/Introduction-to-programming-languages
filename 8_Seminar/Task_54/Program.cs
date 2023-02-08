// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
List<int> sortedList = new List<int>();

FillArray(array);
PrintArray(array);
sortedList.AddRange(Sort(array));
FillSortedArray(sortedList, array);
PrintArray(array);

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
List<int> Sort(int[,] arr)
{
    List<int> rowsList = new List<int>();
    List<int> sortedList = new List<int>();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowsList.Add(arr[i, j]);
        }
        sortedList.AddRange(SelectionSort(rowsList));
        rowsList.Clear();
    }
    return sortedList;
}
void FillSortedArray(List<int> list, int[,] arr)
{
    int j = 0;
    int k = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (k == arr.GetLength(1))
        {
            k = 0;
            j++;
        }
        arr[j, k] = list[i];
        k++;
    }
}
void PrintList(List<int> list)
{
    for (int k = 0; k < list.Count; k++)
    {
        Console.Write(list[k] + " ");
    }
}
List<int> SelectionSort(List<int> collection)
{
    var highest = 0;
    List<int> newList = new List<int>();
    for (; collection.Count != 0;)
    {
        highest = FindHighest(collection);
        newList.Add(collection[highest]);
        collection.RemoveAt(highest);
    }
    return newList;
}
int FindHighest(List<int> collection)
{
    int highest = collection[0];
    int highestIndex = 0;
    for (int i = 1; i < collection.Count; i++)
    {
        if (collection[i] > highest)
        {
            highest = collection[i];
            highestIndex = i;
        }
    }
    return highestIndex;
}