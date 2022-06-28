Console.WriteLine("Введите координаты точки X и Y");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//   Console.WriteLine("1 четверть");

// }
// else if (x < 0 && y > 0)
// {
//   Console.WriteLine("2 четверть");
// }
// else if (x < 0 && y < 0)
// {
//   Console.WriteLine("3 четверть");
// }
// else if (x > 0 && y < 0)
// {
//   Console.WriteLine("4 четверть");
// }
// else
// {
//   Console.WriteLine("Введены некорректные координаты");
// }

string Quard(int xc, int yc)
{
  if (xc > 0 && yc > 0) return "1 четверть";
  if (xc < 0 && yc > 0) return "2 четверть";
  if (xc < 0 && yc < 0) return "3 четверть";
  if (xc > 0 && yc < 0) return "4 четверть";
  else  return "Введены некорректные координаты";
}
string result = Quard(x, y);
Console.WriteLine(result);
