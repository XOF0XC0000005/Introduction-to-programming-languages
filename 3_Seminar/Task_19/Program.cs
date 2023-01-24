 Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int resultNum = num;
 int reverseNum = num % 10;
 num /= 10;
 while(num != 0)
 {
    reverseNum *= 10;
    reverseNum += num % 10;
    num /= 10;
 }
 Console.Write(resultNum + " -> ");
 if(resultNum == reverseNum) Console.Write("Да");
 else Console.Write("Нет");

////Задание Task_19
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int resultNum = num;
// string reverseNum = "";
// while(num != 0)
// {
//     reverseNum += num % 10;
//     num /= 10;
// }
// Console.Write(resultNum + " -> ");
// if(resultNum == Convert.ToInt32(reverseNum)) Console.Write("Да");
// else Console.Write("Нет");