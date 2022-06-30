// Сортировка одномерного массива методом минимакс - метод выбора

int[] array = { 3, 7, 4, 2, 89, 23, 2 };

void PrintArray(int[] arr)
{
  int length = arr.Length;
  for (int i = 0; i < length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] arr)
{
  int length = arr.Length;
  for (int i = 0; i < length - 1; i++)
  {
    int minPosition = i;
    for (int j = i + 1; j < length; j++)
    {
      if (arr[j] < arr[minPosition]) minPosition = j;
    }
    int tmp = arr[i];
    arr[i] = arr[minPosition];
    arr[minPosition] = tmp;
  }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);