Console.Clear();
Console.Write("Введите количество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
int[] a = new int[n + 2];
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a[i]);
}
a[n] = a[0];
a[n + 1] = a[1];
for (int i = 1; i < n + 1; i++) // цикл нахождения суммы для каждого i элемента
{
    int s1 = a[i - 1] + a[i] + a[i + 1];
    if (s1 > s) // условие нахождения максимальной суммы
    s = s1;
}
Console.WriteLine($"максимальная сумма: {s}");


