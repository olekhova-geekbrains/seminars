// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
  bool isNotThreeDigit = num / 100 == 0 || Math.Abs(num / 100) >= 10;
  if (isNotThreeDigit) return 0;
  int secondDigit = Math.Abs((num % 100) / 10);
  return secondDigit;
}

int secondDigit = SecondDigit(number);
string result = secondDigit > 0 ? $"Вторая цифра числа {number}: {secondDigit}" : "Это не трёхзначное число";
Console.WriteLine(result);
