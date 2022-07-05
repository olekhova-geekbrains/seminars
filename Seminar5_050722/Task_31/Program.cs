// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите 
// сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20. 

// int[] array = new int[12];
// var rnd = new Random();

// int index = 0;
// while (index < array.Length)
// {
//   array[index] = rnd.Next(-9, 10);
//   Console.Write($"{array[index]} ");
//   index++;
// }
// Console.WriteLine();

// int sumPos = 0;
// int sumNeg = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] < 0) sumNeg += array[i];
//   else sumPos += array[i];
// }

// Console.WriteLine($"Сумма положительных чисел равна {sumPos}");
// Console.WriteLine($"Сумма отрицательных чисел равна {sumNeg}");

int[] CreateArrayRndInt(int size)
{
  int[] array = new int[size];
  var rnd = new Random();

  int index = 0;
  while (index < array.Length)
  {
    array[index] = rnd.Next(-9, 10);
    index++;
  }
  return array;
}

int[] GetSumNegPosElem(int[] arr)
{
  int sumPos = 0;
  int sumNeg = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < 0) sumNeg += arr[i];
    else sumPos += arr[i];
  }
  return new int[] { sumPos, sumNeg };
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

int[] array = CreateArrayRndInt(12);
PrintArray(array);
int[] getSumNegPosElem = GetSumNegPosElem(array);
Console.WriteLine($"Сумма положительных чисел равна {getSumNegPosElem[0]}");
Console.WriteLine($"Сумма отрицательных чисел равна {getSumNegPosElem[1]}");
