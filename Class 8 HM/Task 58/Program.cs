/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

//Console.Clear();

int[,] InputMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);

        }
    }
    return matrix;
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

int Multiplying(int[,] A, int[,] B, int StartRow, int StartCol)
{
    int RowSum = 0;
    for (int i = 0; i < A.GetLength(1); i++)
    {
        RowSum += A[StartRow, i] * B[i, StartCol];
    }
    return RowSum;
}

int[,] ResultMatrix(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(0)];
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            C[i, j] = Multiplying(A, B, i, j);

        }
    }
    return C;
}


Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = InputMatrix(row, col);
int[,] matrix2 = InputMatrix(row, col);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(ResultMatrix(matrix1, matrix2));
