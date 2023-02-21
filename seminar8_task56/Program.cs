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


int MinSum(int[,] matrix, int[]array)
{
    int result = 0;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        result = sum;
        array[k] = result;
        k++;
    }
    Console.WriteLine($"Сумма каждой строки: [{string.Join(", ", array)}]");
    int min = array[0];
    int index = 0;
    for (int n = 1; n < matrix.GetLength(0); n++)
        if (min > array[n])
        {
        min = array[n];
        index = n;
        index++;
        }
    Console.WriteLine($"Минимальная сумма {min}");
    Console.WriteLine($"Строка с минимальной суммой {index}");
    return result;
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[matrix.GetLength(0)];
InputMatrix(matrix);
PrintMatrix(matrix);
MinSum(matrix, array);
