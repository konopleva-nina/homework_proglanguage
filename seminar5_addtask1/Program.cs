Console.Clear();
Console.Write("Введите число от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int nums = 0;
int nums1 = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 32); 
    if (array[i] % 2 == 0)
    {
        nums++;
    }
    if (array[i] % 2 == 1)
    {
        nums1++;
    }
}
Console.WriteLine($"Mассив исходный: [{string.Join(", ", array)}]");
int[] array2 = new int[nums];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] % 2 ==0)
    {
        array2[j] = array[i];
        j++;
    }
}
Console.WriteLine($"Mассив c четными числами (Вася получал четверки): [{string.Join(", ", array2)}]");
int[] array3 = new int[nums1];
int k = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] % 2 == 1)
    {
        array3[k] = array[i];
        k++;
    }
}
Console.WriteLine($"Mассив c нечетными числами (Вася получал тройки): [{string.Join(", ", array3)}]");
if (nums >= nums1)
Console.WriteLine("ДА! Вася получит четверку :)");
else
Console.WriteLine("Нет. Вася получит тройку :(");
