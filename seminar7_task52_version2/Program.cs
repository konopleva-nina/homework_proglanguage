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


double ArithmeticMean(int[,] matrix, double[] array)
{
    double result = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        result = sum / matrix.GetLength(0);
        array[k] = Math.Round(result, 2);
        k++;
    }
    Console.WriteLine($"Среднее арифметиеское каждого столбца: [{string.Join(", ", array)}]");
    return result;
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
double[] array = new double[matrix.GetLength(1)];
InputMatrix(matrix);
PrintMatrix(matrix);
ArithmeticMean(matrix, array);
