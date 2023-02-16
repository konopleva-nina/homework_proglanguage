Console.Clear();
Console.Write("Введите число x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

double sqr = Math.Abs(((x1 - x2)*(y3 - y1) - (x3 - x1)*(y2 - y1)) / 2);
Console.WriteLine($"Площадь треугольника: {sqr}");
