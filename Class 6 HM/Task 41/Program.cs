// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void InputNumber(int m)
{
    int count = 1;
    int amount = 0;
    Console.WriteLine($"Введите " + m + " чисел:");
    Console.WriteLine();
    while (count <= m)
    {
        Console.Write($"Введите " + count + " число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        count++;
        if (n > 0)
            amount++;
    }
    Console.WriteLine(amount);
}

InputNumber(10);