
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

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

int FindNum(int[] arr)
{ 
  int i = 0; 
  int count = 0; 
  while (i < arr.Length) 
  { 
    if (arr[i] >= 10 && arr[i] <= 99) count++; 
    i++; 
  } 
  return count; 
}

int[] array = CreateArrayRndInt(123, 1, 200);
PrintArray(array);
int count = FindNum(array); 
Console.WriteLine(count);
