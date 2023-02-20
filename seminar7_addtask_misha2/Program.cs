void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 2); // [0, 1]
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

int ReleaseMatrix(int[,] matrix, int[,] matrixMisha)
{
    int count = 0;
    for (int i = 0; i < matrixMisha.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMisha.GetLength(1); j++)
        if (matrix[i, j] == matrixMisha[i, j])
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
int[,] matrixMisha = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Мишин массив:");
PrintMatrix(matrix);
Console.WriteLine($"Результат: {ReleaseMatrix(matrix, matrixMisha)}");
