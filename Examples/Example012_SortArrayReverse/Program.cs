// Сортировка одномерного массива методом минимакс - метод выбора 
// от большего к меньшему

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

void SelectionSortReverse(int[] arr)
{
  int length = arr.Length;
  for (int i = 0; i < length - 1; i++)
  {
    int maxPosition = i;
    for (int j = i + 1; j < length; j++)
    {
      if (arr[j] > arr[maxPosition]) maxPosition = j;
    }
    int tmp = arr[i];
    arr[i] = arr[maxPosition];
    arr[maxPosition] = tmp;
  }
}

PrintArray(array);
SelectionSortReverse(array);
PrintArray(array);
