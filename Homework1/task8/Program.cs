﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2)
{
  Console.WriteLine("Таких чисел нет");
}
else
{
  int i = 2;
  while (i <= num) {
    Console.Write($"{i}, ");
    i += 2;
  }
}
