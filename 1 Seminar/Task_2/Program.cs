Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber){
    Console.WriteLine("max = " + firstNumber);
} else {
    Console.WriteLine("max = " + secondNumber);
}

