Console.Clear();
Console.Write("Введите количество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
int[] a = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
    Console.WriteLine(a[i] = rand.Next(1, 10));
for (int i = 1; i < a.Length - 1; i++) 
{
    int s1 = a[i - 1] + a[i] + a[i + 1];

    if (s1 > s) 
    s = s1;
}
int s2 = a[a.Length - 1] + a[0] + a[1];
if (s2 > s)
s = s2;
int s3 = a[a.Length - 2] + a[a.Length - 1] + a[0];
if (s3 > s)
s = s3;

Console.WriteLine($"максимальная сумма: {s}");


