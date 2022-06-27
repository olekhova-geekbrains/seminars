// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
  int tmpNum = Math.Abs(num);
  if (tmpNum < 100) return -1;
  while (tmpNum >= 1000)
  {
    tmpNum = tmpNum / 10;
  }
  int res = tmpNum % 10;
  return res;
}

int thirdDigit = ThirdDigit(number);
string result = thirdDigit >= 0 ? $"Третья цифра: {thirdDigit}" : "третьей цифры нет";
Console.WriteLine(result);
