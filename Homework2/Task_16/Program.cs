// Задача 16: Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string IsSquare(int a, int b)
{
  if (a * a == b || b * b == a) return "да";
  return "нет";
}

Console.WriteLine(IsSquare(num1, num2));
