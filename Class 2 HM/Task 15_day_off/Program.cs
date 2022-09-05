Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

void day()
{
    if (n > 0 && n < 6) Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}

if (n < 1 || n > 7) Console.WriteLine("Число введено неверно");
else day();