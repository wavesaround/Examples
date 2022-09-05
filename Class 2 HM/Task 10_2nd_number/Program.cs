
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void CompreiseNumbers()
{
    int a = n % 100;
    Console.WriteLine(a / 10);
}

if (n > 99 && n < 1000) CompreiseNumbers();

else Console.WriteLine("Вы ввели неверное значение!");
