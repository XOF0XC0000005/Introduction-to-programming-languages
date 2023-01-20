Console.Write("Введите координаты X, Y, Z точки А через пробел: ");
string aCoordinates = Console.ReadLine();
Console.Write("Введите координаты X, Y, Z точки B через пробел: ");
string bCoordinates = Console.ReadLine();
var aArray = aCoordinates.Split(" ").Select(double.Parse).ToArray();
var bArray = bCoordinates.Split(" ").Select(double.Parse).ToArray();
double result = Math.Round(Math.Sqrt(Math.Pow(aArray[0] - bArray[0], 2) + Math.Pow(aArray[1] - bArray[1], 2) + Math.Pow(aArray[2] - bArray[2], 2)), 3);
Console.Write($"A ({aArray[0]}, {aArray[1]}, {aArray[2]}); B({bArray[0]}, {bArray[1]}, {bArray[2]}) -> " + result);