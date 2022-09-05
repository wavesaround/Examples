/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет */

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void number()
{
    if (n > 99)
    {

        while (n > 999)
        {
            n = n / 10;
        }
        Console.WriteLine(n % 10);
    }

    else Console.WriteLine("Третьей цифры нет ");
}

number();