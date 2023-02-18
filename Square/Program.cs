/* По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
требуется вычислить его площадь.*/

Console.Clear();
Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
double S = Math.Abs((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1)) / 2;
Console.WriteLine($"Площадь треугольника: {S}");