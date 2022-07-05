// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int EvenNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] % 2 == 0) count++;
  }
  return count;
}

int[] array = CreateArrayRndInt(6, 100, 1000);
PrintArray(array);
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"Количество четных элементов - {evenNumbers}");