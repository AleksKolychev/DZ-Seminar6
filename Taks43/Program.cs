/* Напишите программу, которая найдет точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.*/
 
 Console.Clear();
Console.Write("Введите коэффициент(1-ой прямой): ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член(1-ой прямой): ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент(2-ой прямой): ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член(2-ой прямой): ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");