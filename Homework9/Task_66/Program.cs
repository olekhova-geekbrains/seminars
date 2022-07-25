// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = Sum(numM, numN);
Console.WriteLine($"сумма натуральных элементов в промежутке от M до N равна {sum}");

int Sum(int a, int b)
{
  if (a == b) return a;
  if (a < b)
  {
    return a + Sum(a + 1, b);
  }
  else return b + Sum(a, b + 1);
}
