/*
Дана последовательность чисел и число K
Необходимо сдвинуть всю последовательность вправо на K элементов, если К положительное и влево, если К отрицательное
*/

Console.Clear();

int[] First = { 5, 3, 7, 4, 6, 8 };
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Move(int[] array, int n)
{
    int[] newArray = new int[array.Length];
    int j = 0;
    if (n < 0)
        while (n <= 0)
            n = n + array.Length;

    if (n > array.Length)
        while (n > array.Length)
            n -= array.Length;
    for (int i = 0; i < array.Length - n; i++)
    {
        newArray[i + n] = array[i];
        j++;
    }
    for (int i = 0; i < n; i++)
    {
        newArray[i] = array[j];
        j++;
    }
    Console.WriteLine(string.Join(", ", newArray));
}

Move(First, n);