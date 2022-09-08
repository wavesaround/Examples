Console.Clear();
Console.WriteLine("Введите 5-значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Palindrom()
{
    int a = 0;
    int b = 0;
    a = n / 1000;
    b = n % 100;
    b = (b % 10) * 10 + (b / 10);

    if (a == b)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

if (n < 10000 || n > 99999) Console.WriteLine("Значение не соответствует условию");
else Palindrom();