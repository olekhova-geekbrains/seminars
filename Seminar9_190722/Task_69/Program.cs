// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число - показатель степени: ");
int power = Convert.ToInt32(Console.ReadLine());

double Pow(double a, int b)
{
  if (b >= 0)
  {
    if (b == 0) return 1;
    return a * Pow(a, b - 1);
  }
  else
  {
    if (b == 0) return 1;
    return (1/a) * Pow(a, b + 1);
  }
}

string result = $"Число {number} в степени {power} => {Pow(number, power)}";
Console.WriteLine(result);