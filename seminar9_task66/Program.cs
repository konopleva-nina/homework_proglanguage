int rec(int m, int n)
{
    if (n == m)
        return m;
    return n + rec(m, n - 1);
}


Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
