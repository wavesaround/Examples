// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
    {
        Console.WriteLine("max = " + n);
        Console.WriteLine("min = " + m);
    }

else
    {
        Console.WriteLine("max = " + m);
        Console.WriteLine("min = " + n);
    }
