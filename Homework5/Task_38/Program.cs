// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArrayRndDouble(int size, double minElement, double maxElement)
{
  double[] arr = new double[size];
  var rnd = new Random();

  int index = 0;
  while (index < arr.Length)
  {
    arr[index] = Math.Round(rnd.NextDouble() * (maxElement - minElement) + minElement, 2);
    index++;
  }
  return arr;
}

void PrintArray(double[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.WriteLine(arr[i] + "]");
  }
}

double[] FindDiffMaxMin(double[] arr)
{
  double max = arr[0];
  double min = arr[0];
  for (int i = 1; i < arr.Length - 1; i++)
  {
    if (arr[i] > max) max = arr[i];
    else if (arr[i] < min) min = arr[i];
  }

  double diff = max - min;
  return new double[] { diff, max, min };
}

double[] array = CreateArrayRndDouble(5, -99, 100);
PrintArray(array);
double[] diffMaxMin = FindDiffMaxMin(array);
Console.WriteLine($"Разница между максимальным {diffMaxMin[1]} и минимальным {diffMaxMin[2]} элементами массива равна {diffMaxMin[0]}");
