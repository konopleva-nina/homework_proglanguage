Console.Clear();
Console.Write("Введите количество элементов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
    array[i] = rand.Next(1, 10);
    Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("Введите число сдвига k: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] b = new int[n]; // вводим дополнительный массив
for (int j = n - 1; j >= 0; j--)
{
    if (k > 0)
    {
    if (j + k >= n) 
    {
        b[j + k - n] = array[j];
    }
    else
    {
        b[j + k] = array[j];
    }
    }
    else
    {
    if (j + k < 0)
    {
        b[j + k + n] = array[j];
    }
    else
    {
        b[j + k] = array[j];
    }
    }

} 
Console.WriteLine($"[{string.Join(", ", b)}]");
