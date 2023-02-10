Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 

Console.WriteLine($"Mассив: [{string.Join(", ", array)}]");
int max = array[0];
int min = array[0];
for(int i = 0; i < n; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min) 
    {
        min = array[i];
    }
}
int res = max - min;
Console.WriteLine($"Максимум: {max}");
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Разница: {res}");

