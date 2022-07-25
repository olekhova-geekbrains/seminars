// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) Console.WriteLine("Введено некорректное значение");
else NaturalNumbers(num);

void NaturalNumbers(int n)
{
  if (n == 0) return;
  if (n == 1) Console.WriteLine($"{n}");
  else Console.Write($"{n}, ");
  NaturalNumbers(n - 1);
}
