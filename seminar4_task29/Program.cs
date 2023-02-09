Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
    array[i] = rand.Next(1, 10);
    Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("Введите число х из массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int res = 0;
for (int i = 0; i < n; i++)
{
    if (x == array[i])
    res = res + 1;
}
Console.WriteLine($"Количество вхождений числа х: {res}");





