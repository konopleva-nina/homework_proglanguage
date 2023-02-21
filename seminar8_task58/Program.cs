void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); 
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int [,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    var element = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            element = matrixA[i, j] * matrixB[i, j];
            matrixC[i, j] = element;
        }
    }
    return matrixC;
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[size[0], size[1]];
InputMatrix(matrixA);
Console.WriteLine("Первый массив:");
PrintMatrix(matrixA);
int[,] matrixB = new int[size[0], size[1]];
InputMatrix(matrixB);
Console.WriteLine("Второй массив:");
PrintMatrix(matrixB);
var result = MatrixMultiplication(matrixA, matrixB);
Console.WriteLine($"Результирующий массив:");
PrintMatrix(result);
