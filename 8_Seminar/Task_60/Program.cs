// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];

FillUniqueArray(UniqueNumber(array), array);
PrintArray(array);
PrintArrayWithIndexes(array);

void PrintArrayWithIndexes(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],2}({i},{j},{k}) ");
            }
        }
    }
}
void FillUniqueArray(List<int> list, int[,,] arr)
{
    int j = 0;
    int k = 0;
    int l = 0;

    for (int i = 0; i < list.Count; i++)
    {
        if (l == arr.GetLength(2))
        {
            l = 0;
            k++;
        }
        if (k == arr.GetLength(1))
        {
            k = 0;
            j++;
        }
        arr[j, k, l] = list[i];
        l++;
    }
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],5}");
            }

        }
    }
    Console.WriteLine();
}
List<int> UniqueNumber(int[,,] arr)
{
    Random random = new Random();
    int num = 0;
    List<int> uniqueList = new List<int>();
    for (int i = 0; i < arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2); i++)
    {
        do
        {
            num = random.Next(10, 100);

        } while (uniqueList.IndexOf(num) != -1);
        uniqueList.Add(num);
    }
    return uniqueList;
}