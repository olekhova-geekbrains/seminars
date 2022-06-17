// Ввести два числа. Проверить является ли первое число квадратом второго

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2) {
  Console.WriteLine("да");
}
else {
  Console.WriteLine("нет");
}
