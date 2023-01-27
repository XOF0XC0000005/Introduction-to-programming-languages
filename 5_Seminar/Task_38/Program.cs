// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.Write("]");
Console.Write($" -> {SubstractMaxMin(array)}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 101);
    }
}

int SubstractMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[1];

    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
    }
    return max - min;
}

