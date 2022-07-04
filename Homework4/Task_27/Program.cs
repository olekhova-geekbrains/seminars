// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSumDigit(int num)
{
  int res = 0;
  int n = num;
  while (n != 0)
  {
    res += n % 10;
    n /= 10;
  }
  return res;
}

int result = GetSumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}");