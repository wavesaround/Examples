/* Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] matrix)
{
    
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int times = 0;
        while (times < matrix.GetLength(1))
        {
            int pos = 0;
            int MaxValue = 0;
            for (int j = times; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > MaxValue)
                {
                    MaxValue = matrix[i, j];
                    pos = j;
                }
            }
            matrix[i, pos] = matrix[i, times];
            matrix[i, times] = MaxValue;
            times++;
        }
    }
}

int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Sort(matrix);
PrintMatrix(matrix);