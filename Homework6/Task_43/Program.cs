// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] FindIntersectionPoint(double kl1, double bl1, double kl2, double bl2)
{
  double xl = Math.Round((bl2 - bl1) / (kl1 - kl2), 2);
  double yl = Math.Round(kl1 * xl + bl1, 2);
  return new double[]{ xl, yl };
}

string result = "";
if (k1 == k2 && b1 == b2) result = "Прямые совпали - точки пересечения нет.";
else if (k1 == k2) result = "Прямые параллельны - точки пересечения нет";
else
{
  double[] intersectionPoint = FindIntersectionPoint(k1, b1, k2, b2);
  result = $"Точка пересечения прямых ({intersectionPoint[0]}; {intersectionPoint[1]})";
}
Console.WriteLine(result);
