Console.Clear();
Console.Write("Введите количество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
int[] a = new int[n + 2];
Random rand = new Random();
for (int i = 0; i < n; i++)
    Console.WriteLine(a[i] = rand.Next(1, 10));
a[n] = a[0];
a[n + 1] = a[1];
for (int i = 1; i < n + 1; i++) // цикл нахождения суммы для каждого i элемента
{
    int s1 = a[i - 1] + a[i] + a[i + 1];
    int s2 = a[n] + a[0] + a[1];
    int s3 = a[n - 1] + a[n] + a[0];
    if (s1 > s) // условие нахождения максимальной суммы
    s = s1;
    if (s2 > s)
    s = s2;
    if (s3 > s)
    s = s3;
}
Console.WriteLine($"максимальная сумма: {s}");


