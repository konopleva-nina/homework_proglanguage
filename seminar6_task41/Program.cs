Console.Clear();
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");