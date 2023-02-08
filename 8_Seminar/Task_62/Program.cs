﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//00 01 02 03
//10 11 12 13
//20 21 22 23
//30 31 32 33

//00 01 02 03   13 23 33   32 31 30  20 10  11 12  22 21

int[,] array = new int[4, 4];

int i = 0;
int j = 0;
int num = 1;
Right();
Down();
Left();
Up();
Right();
Down();
Left();
PrintArray(array);

void Up()
{
    while (i > 0)
    {
        if(array[i,j] != 0 ) break;
        array[i, j] = num;
        i--;
        num++;
    }
    i++;
    j++;
}
void Left()
{
    while (j >= 0)
    {
        if (array[i, j] != 0) break;
        array[i, j] = num;
        j--;
        num++;
    }
    j++;
    i--;
}
void Right()
{
    while (j < array.GetLength(1))
    {
        if (array[i, j] != 0) break;
        array[i, j] = num;
        num++;
        j++;
    }
    i++;
    j--;
}
void Down()
{
    while (i < array.GetLength(0))
    {
        if (array[i, j] != 0) break;
        array[i, j] = num;
        num++;
        i++;
    }
    i--;
    j--;
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