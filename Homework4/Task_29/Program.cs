// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int length = 8; // либо пользователь сам вводит длину массива

int[] GetArray(int len)
{
  int[] arr = new int[len];
  int index = 0;

  // Вариант 1. Массив из случайных чисел.
  var rnd = new Random();
  while (index < len)
  {
    arr[index] = rnd.Next(0, 100);
    index++;
  }

  // Вариант 2. Элементы массива задает пользователь.
  // while (index < len)
  // {
  //   Console.Write("Введите число - элемент массива: ");
  //   arr[index] = Convert.ToInt32(Console.ReadLine());
  //   index++;
  // }

  return arr;
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.WriteLine(arr[i] + "]");
  }
}
int[] array = GetArray(length);
PrintArray(array);