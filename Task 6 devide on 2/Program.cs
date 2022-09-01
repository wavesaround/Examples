// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0) { n = n * (-1); }

if (n % 2 == 1)
{
    Console.Write("НЕТ");
}

else Console.Write("ДА");