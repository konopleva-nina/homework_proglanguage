Console.Clear();
Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (b1 == b2 && k1 == k2)
Console.WriteLine($"Прямые совпадают");
else if (k1 == k2) 
Console.WriteLine($"Прямые параллельны");
else 
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Тока пересечения заданных прямых: ({x}; {y})");
}

