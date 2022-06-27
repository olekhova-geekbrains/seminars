// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

string DayOff(int num)
{
  string res;
  if (num < 1 || num > 7) res = "некорректный ввод";
  else if (num == 6 || num == 7) res = "да";
  else res = "нет";
  return res;
}

string result = DayOff(number);
Console.WriteLine(result);
