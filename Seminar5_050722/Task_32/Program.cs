// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] Change(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = -arr[i];
  }
  return newArr;
}

int[] array = CreateArrayRndInt(5, -99, 100);
PrintArray(array);
int[] newArray = Change(array);
PrintArray(newArray);
