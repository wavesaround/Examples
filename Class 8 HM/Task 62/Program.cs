
Console.Clear();

int[,] matrix = new int[4, 4];

void InputMatrix()
{
    int count = 1;
    int times = 0;
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    while (count <= rows * cols)
    {
        if (times < cols - times - 1)
        {
            for (int j = times; j < cols - times - 1; j++)
            {
                matrix[times, j] = count;
                count++;
            }
        }
        else
        {
            for (int j = times; j < cols - times; j++)
            {
                matrix[times, j] = count;
                count++;
            }
        }
        for (int j = times; j < rows - 1 - times; j++)
        {
            matrix[j, cols - times - 1] = count;
            count++;
        }
        for (int j = cols - 1 - times; j > times; --j)
        {
            matrix[rows - 1 - times, j] = count;
            count++;
        }
        for (int j = rows - 1 - times; j > times; --j)
        {
            matrix[j, times] = count;
            count++;
        }
        times++;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
                Console.Write(matrix[i, j] + "  ");
            else
                Console.Write("0" + matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

InputMatrix();
PrintMatrix(matrix);