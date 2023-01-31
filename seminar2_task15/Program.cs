Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 5 && n < 8)
    Console.WriteLine("да");
else if (n > 0 && n < 6)
    Console.WriteLine("нет");
else 
    Console.WriteLine("Вы ввели число не в пределах от 1 до 7");