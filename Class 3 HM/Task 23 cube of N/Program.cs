Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (n <= 0) Console.WriteLine("Введите число больше нуля");

while (i <= n)
{
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
}