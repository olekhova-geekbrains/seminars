// Задача 23
// Напишите программу, которая 
// принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void GetNumberCubes(int num)
{
  if (num <= 0) Console.WriteLine("Некорректный ввод");
  for (int i = 1; i <= num; i++)
  {
    Console.WriteLine($"| куб числа {i} | {i * i * i,2} |");
  }
}

GetNumberCubes(number);
