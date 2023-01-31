// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

int number = 2;
string result = "";

if (a < number)
{
    Console.WriteLine("Четных чисел нет");
}

else
{
    while (number <= a)
    {
        result +=" "+ number;
        number += 2;
    }
    Console.WriteLine("Четные числа:" + result);
}

