//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.Write("Введите первое число (целое): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (целое): ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine($"Числа равны ({num1})");
}
else if (num1 > num2)
{
    Console.WriteLine($"Большее число {num1}, меньшее число {num2}");
}
else
{
    Console.WriteLine($"Большее число {num2}, меньшее число {num1}");
}