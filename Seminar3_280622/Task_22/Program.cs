// Задача 22: Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 
// 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 12 мин 

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0) Console.WriteLine("Некорректный ввод");

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"| Квадрат числа {i} | {i * i, 2} |");
}
