Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 

Console.WriteLine($"Mассив: [{string.Join(", ", array)}]");
int sum = 0;
for(int i = 1; i < n; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");