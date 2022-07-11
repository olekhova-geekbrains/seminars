// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size)
{
  int[] array = new int[size];
  var rnd = new Random();

  int index = 0;
  while (index < array.Length)
  {
    array[index] = rnd.Next(1, 10);
    index++;
  }
  return array;
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

// void Reverse(int[] arr)
// {
//   for (int i = 0; i < arr.Length / 2; i++)
//   {
//     int tmp = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = tmp;
//   }
// }

int[] Reverse(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = arr[arr.Length - 1 - i];
  }
  return newArr;
}

int[] array = CreateArrayRndInt(5);
PrintArray(array);
int[] reverseArray = Reverse(array);
PrintArray(reverseArray);
