// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] CreateArrayRndInt(int size, int minElement, int maxElement)
{
  int[] arr = new int[size];
  var rnd = new Random();

  int index = 0;
  while (index < arr.Length)
  {
    arr[index] = rnd.Next(minElement, maxElement + 1);
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

int SumOddIndex(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i += 2)
  {
    sum += arr[i];
  }
  return sum;
}

int[] array = CreateArrayRndInt(4, -99, 99);
PrintArray(array);
int sumOddIndex = SumOddIndex(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sumOddIndex}");
