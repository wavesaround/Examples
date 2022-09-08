Console.Clear();
Console.WriteLine("Введите X 1: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y 1: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z 1: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Введите X 2: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y 2: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z 2: ");
int bz = Convert.ToInt32(Console.ReadLine());


void FindL(int a, int b, int c, int d, int e, int f)
{
    double L = Math.Sqrt(Math.Pow(d - a, 2) + Math.Pow(e - b, 2) + Math.Pow(f - c, 2));
    Console.WriteLine("Расстояние " + Math.Round(L, 2));
}

FindL(ax, ay, az, bx, by, bz);