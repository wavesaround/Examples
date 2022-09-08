Console.Clear();

int[] array = { -20, 30, -40, 50, 10, -10 };
int[] array2 = {10, 20, 30, 1, -10, 1, 2, 3};
int[] array3 = {-10, 0, -10, 0, -10};
int count = 0;
int buff = 0;

foreach (int i in array)
{
    if (i > 0) count++;
    if (i <= 0)
    {
        if (count > buff)
        {
            buff = count;
            count = 0;
        }
        else count = 0;
    }
}

Console.Write(buff);