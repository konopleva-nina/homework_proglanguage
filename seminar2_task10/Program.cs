Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    int n1 = n % 100;
    int n2 = n1 / 10;
    Console.WriteLine(n2);
} 
else
Console.WriteLine("Вы ввели не трехзначное число");