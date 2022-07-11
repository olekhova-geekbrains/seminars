// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size)
{
  int[] array = new int[size];
  var rnd = new Random();

  int index = 0;
  while (index < array.Length)
  {
    array[index] = rnd.Next(0, 100);
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

int[] CopyArray(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = arr[i];
  }
  return newArr;
}

int[] array = CreateArrayRndInt(10);
int[] newArray = CopyArray(array);
PrintArray(array);
PrintArray(newArray);