﻿void InputMatrix(int[,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
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


Console.Clear();
Console.Write("Введите размер квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
Console.WriteLine("Массив заполненный по спирали:");
InputMatrix(matrix);
PrintMatrix(matrix);
