int[] array1 = { 1, 7, 9, 0 };
int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 0, 8, 9, 10 };


void MaxMin(int[] array)
{
int max = 0;
int max2 = 0;
int i = 0;

    while (array[i] != 0)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
            i++;
        }
        else i++;
    }

    Console.WriteLine(max);
    Console.WriteLine(max2);

}

MaxMin(array1);
Console.WriteLine("---");
MaxMin(array2);