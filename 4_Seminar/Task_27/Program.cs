//Усложнения
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int workingNumber = num;
List<int> digitsList = new List<int>();
FillList(workingNumber, digitsList);
List<int> uniqueDigits = findUniqueDigits(digitsList);
Console.Write($"{num} -> ");
ShowList(uniqueDigits);

void FillList(int number, List<int> list)
{
    while (number != 0)
    {
        digitsList.Add(number % 10);
        number /= 10;
    }
}

void ShowList(List<int> list)
{
    foreach(var item in list)
    {
        Console.Write(item + " ");
    }
}

List<int> findUniqueDigits(List<int> list)
{
    List<int> uniqueDigits = new List<int>();

    for(int i = 0; i < list.Count; i++)
    {
        int uniqueNumber = list[i];
        int uniqueCurrentIndex = i;
        bool isUnique = true;

        for(int j = 0; j < list.Count; j++)
        {
            if(list[i] == list[j] && uniqueCurrentIndex != j) isUnique = false;
        }
        if(isUnique) uniqueDigits.Add(list[i]);
        isUnique = true;
    }
    uniqueDigits.Reverse();
    return uniqueDigits;
}

// Домашка
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{num} -> {DigitsSum(num)}");

// int DigitsSum(int num)
// {
//     int result = 0;
//     while (num != 0)
//     {
//         result += num % 10;
//         num /= 10;
//     }
//     return result;
// }