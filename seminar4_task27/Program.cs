Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), sum = 0;
while (n > 0)
{
    int n1 = n % 10;
    sum = sum + n1;
    n = n / 10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");