/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
Пример
1 4 7 2
5 9 2 3
8 4 2 4
Ввод:
2 строка
1 столбец
Вывод: 
4 */

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

void FindElement(int[,] matrix, int m, int n)
{
    if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
        Console.WriteLine(matrix[m - 1, n - 1]);
    else Console.WriteLine("Такого элемента нет");
}

int[,] matrix = new int[4, 4];
Console.WriteLine("Введите искомую строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый столбец: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindElement(matrix, m, n);