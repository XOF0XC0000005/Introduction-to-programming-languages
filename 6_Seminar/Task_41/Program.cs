// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using System.Linq;

Console.Write("Введите колличество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
MoreThanZero(FillArray(length));

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void MoreThanZero(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array) + "] -> ");
    Console.Write(array.Where(s => s > 0).Count());
}
