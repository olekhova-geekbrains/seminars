// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigit(num);
Console.WriteLine(sum);

int SumOfDigit(int digit)
{
  if (digit > 0)
  {
    return digit % 10 + SumOfDigit(digit / 10);
  }
  return 0;
}