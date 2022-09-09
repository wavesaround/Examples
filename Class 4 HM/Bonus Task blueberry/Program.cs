Console.Clear();

int[] bb1 = { 1, 2, 3, 4 };
int[] bb2 = { 1, 2, 3 };
int[] bb3 = { 5, 8, 3, 5, 1, 9, 7 };

void blueberry(int[] array)
{
    int comp = 0;

    for (int i = 1; i < array.Length - 1; i++)
    {
        if ((array[i] + array[i - 1] + array[i + 1]) > comp) 
            comp = array[i] + array[i - 1] + array[i + 1];
    }
    Console.WriteLine(comp);
}

blueberry(bb1);