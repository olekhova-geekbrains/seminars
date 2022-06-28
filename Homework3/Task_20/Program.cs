// Задача 21
// Напишите программу, которая принимает на 
// вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
  double dist = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2) + (c1 - c2) * (c1 - c2));
  dist = Math.Round(dist, 2);
  return dist;
}

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {result}");