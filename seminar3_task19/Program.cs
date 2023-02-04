Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 100000 || n < 10000)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int d1 = n / 10000, d5 = n % 10;
int d2 = (n / 1000) % 10, d4 = (n % 100) / 10;
if (d1 == d5 && d2 == d4)
Console.WriteLine("да");
else
Console.WriteLine("нет");

