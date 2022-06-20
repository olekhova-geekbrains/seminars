// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool isNotThreedigit = num / 100 == 0 || Math.Abs(num / 100) >= 10;

if (isNotThreedigit)
{
  Console.WriteLine("Это не трёхзначное число!");
}
int lastNumber = Math.Abs(num % 10);
Console.WriteLine($"Последняя цифра: {lastNumber}");
