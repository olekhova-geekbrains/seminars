// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int length = 8; // либо пользователь сам вводит длину массива
int[] array = new int[length];
int index = 0;

// Вариант 1. Массив из случайных чисел.
// var rnd = new Random();
// while (index < length)
// {
//   array[index] = rnd.Next(0, 100);
//   index++;
// }


// Вариант 2. Элементы массива задает пользователь.
while(index < length)
{
  Console.Write("Введите число - элемент массива: ");
  array[index] = Convert.ToInt32(Console.ReadLine());
  index++;
}

for (int i = 0; i < length; i++)
{
  if (i == 0) Console.Write("[");
  if (i < length - 1) Console.Write(array[i] + ", ");
  else Console.WriteLine(array[i] + "]");
}