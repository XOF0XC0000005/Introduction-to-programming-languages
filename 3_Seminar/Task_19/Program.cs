Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int resultNum = num;
string reverseNum = "";
while(num != 0)
{
    reverseNum += num % 10;
    num /= 10;
}
Console.Write(resultNum + " -> ");
if(resultNum == Convert.ToInt32(reverseNum)) Console.Write("Да");
else Console.Write("Нет");