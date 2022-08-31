// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int k = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(n > max) { max = n; }
if(m > max) { max = m; }
if(k > max) { max = k; }

Console.WriteLine("Максимальное число: " + max);