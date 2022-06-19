// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на
// выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
  Console.WriteLine("Чисел нет.");
}
else
{
  int i  = -num;
  while (i <= num)
  {
    Console.Write($"{i}, ");
    i += 1;
  }
}
