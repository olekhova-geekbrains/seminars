// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел будет введено с клавиатуры? ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  {
    Console.WriteLine("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

int PosNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) count++;
  }
  return count;
}

int[] array = CreateArray(number);
int posNumbers = PosNumbers(array);
Console.WriteLine($"Количество положительных чисел равно {posNumbers}");
