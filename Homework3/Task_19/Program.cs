// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsPalindrom(int num)
{
  int firstDigit = num / 10000;
  int secondDigit = (num / 1000) % 10;
  int fourthDigit = (num / 10) % 10;
  int fifthDigit = num % 10;
  if (fifthDigit == fifthDigit && secondDigit == fourthDigit) return true;
  return false;
}

string result;
if (Math.Abs(number) > 9999 && Math.Abs(number) < 100000)
{
  result = IsPalindrom(number) ? "да" : "нет";
}
else
{
  result = "некорректный ввод";
}

Console.WriteLine(result);