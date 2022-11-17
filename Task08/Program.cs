//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.Write("Чтобы узнать все четные числа от 1 до N, введите N (целое положительное число): ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num < 2)
{
    Console.WriteLine("Ошибка! Введите число больше 1");
}
else
{
    Console.Write($"Четные числа от 1 до {num}: ");

    while (count <= num)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
