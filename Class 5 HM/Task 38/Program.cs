/* 
Задача 38: Задайте массив дробных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3,5 7,78 22 2,23 78, 25] -> 76,02
*/
Console.Clear();

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    Console.WriteLine("[ " + string.Join(", ", array) + " ]");
}

void MaxMin(double[] array)
{
    double max = 0;
    double min = array[0];
    foreach (double i in array)
    {
        if (i > max)
        {
            max = i;
        }
        if (i < min)
            min = i;
    }
//    Console.WriteLine(max);
//    Console.WriteLine(min);
    Console.WriteLine(max - min);
}

double[] arr = new double[6];
InputArray(arr);
MaxMin(arr);