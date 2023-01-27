Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int k = Convert.ToInt32(Console.ReadLine());
int max;
if (n >= m)
{
    if (k >= n)
    {
        max = k;
        Console.WriteLine(k);
    }
    else
    {
        max = n;
        Console.WriteLine(n);
    }
}
else
{
    if (k >= m)
    {
        max = k;
        Console.WriteLine(k);
    }
    else
    {
        max = m;
        Console.WriteLine(m);
    }
}

