// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int num)
{
  int a = 0;
  int b = 1;
  int c = a + b;
  if (num == 1) Console.WriteLine(a);
  else if (num == 2) Console.WriteLine($"{a}, {b}");
  else
  {
    Console.Write($"{a}, {b}, ");
    for (int i = 2; i < num; i++)
    {
      if (i < num - 1)
      {
        Console.Write($"{c}, ");
        a = b;
        b = c;
        c = a + b;
      }
      else Console.WriteLine(c);
    }
  }
}

Fibonacci(number);