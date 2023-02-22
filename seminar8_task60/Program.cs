void CreateMatrix(int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int n = 0; n < temp.GetLength(0); n++)
    {
        temp[n] = new Random().Next(10, 100);
        number = temp[n];
        if (n >= 1)
        {
            for (int m = 0; m < n; m++)
            {
                while (temp[n] == temp[m])
                {
                    temp[n] = new Random().Next(10, 100);
                    m = 0;
                    number = temp[n];
                }
                number = temp[n];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j, k] = temp[count]; 
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}



Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
CreateMatrix(matrix);
PrintMatrix(matrix);