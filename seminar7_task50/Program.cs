void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{   
    Console.Write("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m1 = m - 1, n1 = n - 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        if (m1 == i && n1 == j)
        Console.WriteLine(matrix[m1, n1]);
    }
    if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
    Console.WriteLine("Такого числа в массиве нет");
} 

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);