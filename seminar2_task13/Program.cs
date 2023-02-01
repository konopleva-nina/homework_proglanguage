Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("третьего числа нет");
else
{
    while (n > 1000) n /= 10;
    int n1 = n % 10;
    Console.WriteLine(n1);
}





