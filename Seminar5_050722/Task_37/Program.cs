// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

int[] CreateArrayRndInt(int size, int minElement, int maxElement)
{
  int[] arr = new int[size];
  var rnd = new Random();

  int index = 0;
  while (index < arr.Length)
  {
    arr[index] = rnd.Next(minElement, maxElement);
    index++;
  }
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

int[] GetProizved(int[] arr)
{
  int len;
  if (arr.Length % 2 == 0) len = arr.Length / 2;
  else len = arr.Length / 2 + 1;

  int[] newArr = new int[len];

  if (arr.Length % 2 != 0) newArr[len - 1] = arr[arr.Length / 2];

  for (int i = 0; i < arr.Length / 2; i++)
  {
    newArr[i] = arr[i] * arr[arr.Length - 1 - i];
  }
  return newArr;
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] newArray = GetProizved(array);
PrintArray(newArray);
