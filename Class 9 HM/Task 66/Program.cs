/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */


Console.Clear();

int SumMN(int m, int n)
{
    if (m == n)
        return m;
    else return m + SumMN(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumMN(m, n));
