// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string res = "";
// while (number > 0)
// {
//   res = number % 2 + res;
//   number /= 2;
// }

// string Reverse(string res)
// {
//   string newRes = "";
//   for (int i = res.Length - 1; i >= 0; i--)
//   {
//     newRes += res[i];
//   }
//   return newRes;
// }

// string result = Reverse(res);
// Console.WriteLine(result);
// Console.WriteLine(res);

string ConvertDecToBin(int num)
{
  if (num == 0) return "";
  return ConvertDecToBin(num / 2) + num % 2;
}

string result = ConvertDecToBin(number);
Console.WriteLine(result);