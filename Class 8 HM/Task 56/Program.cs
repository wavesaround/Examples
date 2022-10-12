/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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
        Console.Write("| " + RowSum(matrix, i));
        Console.WriteLine();
    }
}

int RowSum(int[,] matrix, int row)
{
    int SumResult = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        SumResult += matrix[row, i];
    }
    return SumResult;
}

int FindMin(int[,] matrix)
{
    int RowMin = RowSum(matrix, 0);
    int RowPos = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (RowSum(matrix, i) < RowMin)
        {
            RowMin = RowSum(matrix, i);
            RowPos = i;
        }
    }
    return RowPos + 1;
}

int[,] matrix = new int[6, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Строка {FindMin(matrix)}");
