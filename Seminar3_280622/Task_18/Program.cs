// Задача 18: Напишите программу, которая по 
// заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой 
// четверти (x и y). 

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

string Coord(int a)
{
  string res = "";
  if (a == 1) res = "x > 0 и y > 0";
  if (a == 2) res = "x < 0 и y > 0";
  if (a == 3) res = "x < 0 и y < 0";
  if (a == 4) res = "x > 0 и y < 0";
  return res;
}

string result;
if (num > 0 && num < 5)
{
  result = Coord(num);
}
else
{
  result = "некорректный ввод";
}

Console.WriteLine(result);
