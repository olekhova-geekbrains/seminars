// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число - показатель степени: ");
int power = Convert.ToInt32(Console.ReadLine());

int Pow(int a, int b)
{
  int index = 1;
  int res = 1;
  while (index <= b)
  {
    checked
    {
      res *= a;
      index++;
    }
  }
  return res;
}

string result = power > 0 ? $"Число {number} в степени {power} => {Pow(number, power)}" : "Некорректно введен показатель степени!";
Console.WriteLine(result);
