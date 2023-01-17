Console.Write("Введите день недели цифрой: ");
int num = Convert.ToInt32(Console.ReadLine());

MondayCheck(num);
TuesdayCheck(num);
WednesdayCheck(num);
ThursdayCheck(num);
FridayCheck(num);
SaturdayCheck(num);
SundayCheck(num);

void MondayCheck(int number){
    if(number == 1)
    {
        Console.WriteLine(number + " -> нет");
    }
}
void TuesdayCheck(int number){
    if(number == 2)
    {
        Console.WriteLine(number + " -> нет");
    }
}
void WednesdayCheck(int number){
    if(number == 3)
    {
        Console.WriteLine(number + " -> нет");
    }
}
void ThursdayCheck(int number){
    if(number == 4)
    {
        Console.WriteLine(number + " -> нет");
    }
}
void FridayCheck(int number){
    if(number == 5)
    {
        Console.WriteLine(number + " -> нет");
    }
}
void SaturdayCheck(int number){
    if(number == 6)
    {
        Console.WriteLine(number + " -> да");
    }
}
void SundayCheck(int number){
    if(number == 7)
    {
        Console.WriteLine(number + " -> да");
    }
}