Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); 

Console.WriteLine($"Mассив: [{string.Join(", ", array)}]");
int count = 0;
foreach(int element in array)
{
    if (element % 2 == 0)
        count++;
}
Console.WriteLine($"Количество четных чисел: {count}");
