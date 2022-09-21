// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали

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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void trans(int[,] FirstMatrix, int[,] ResultMatrix)
{
    int n = FirstMatrix.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            ResultMatrix[n - i - 1, j] = FirstMatrix[i, j];
        }
    }
}

int[,] matrix = new int[3, 4];
int[,] matrix2 = new int[3, 4];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
trans(matrix, matrix2);
PrintMatrix(matrix2);