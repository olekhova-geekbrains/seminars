// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

// if(numM < numN) NaturalNumbers(numM, numN);
// else NaturalNumbers(numN, numM);

NaturalNumbers(numM, numN);

void NaturalNumbers(int m, int n)
{
  if (m < n)
  {
    NaturalNumbers(m, n - 1);
    Console.Write($"{n} ");
  }
  if (m > n)
  {
    NaturalNumbers(m, n + 1);
    Console.Write($"{n} ");
  }
  if (m == n)
  {
    Console.Write($"{n} ");
  }
}