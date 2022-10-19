/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int[,,] InputMatrix(int row, int col)
{
    int[,,] matrix = new int[row, col, col];
    int temp = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (temp < 100 & temp > 9)
                {
                    matrix[j, k, i] = temp;
                    temp++;
                }
                else return matrix;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[j, k, i] < 100 & matrix[j, k, i] > 9)
                    Console.Write($"{matrix[j, k, i]}  ({j}, {k}, {i})  ");
                else
                    Console.Write($"0{matrix[j, k, i]}  ({j}, {k}, {i})  ");
                
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = InputMatrix(row, col);
PrintMatrix(matrix);