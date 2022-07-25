// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5-> 3 4 7 11 18
// 6 и 10, N = 4-> 6 10 16 26

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число - количество чисел в последовательности: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
  Console.Write($"{GetFibonacci(num1, num2, i)} ");
}

int GetFibonacci(int a, int b, int n)
{
  if (n == 0) return a;
  if (n == 1) return b;
  else return GetFibonacci(a, b, n - 1) + GetFibonacci(a, b, n - 2);
}
