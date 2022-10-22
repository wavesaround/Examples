/* Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */

Console.Clear();

int[,] InputMatrixBorder(int[,] matrix, int n)
{
    int start = matrix.GetLength(1) / 2;
    matrix[0, start] = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        --start;
        matrix[i, start] = 1;
        matrix[i, start + i * 2] = 1;
    }
    return matrix;
}

void InputPascal(int[,] matrix)
{
    int k = 0;
    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) / 2 - k; j <= matrix.GetLength(1) / 2 + k; j += 2)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
        }
        k++;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i < 5)
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
                Console.Write(matrix[i, j]);
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n * 2];
InputMatrixBorder(matrix, n);
InputPascal(matrix);
PrintMatrix(matrix);
