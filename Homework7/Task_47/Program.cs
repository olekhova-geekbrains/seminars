// Задача 47.Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7   -2   -0,2
// 1   -3,3  8   -9,9
// 8    7,8 -7,1  9

Console.WriteLine("Введите количество строк: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
double minElement = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
double maxElement = Convert.ToDouble(Console.ReadLine());

double[,] CreateMatrixRndDouble(int m, int n, double min, double max)
{
  double[,] arr = new double[m, n];
  var rnd = new Random();

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = Math.Round(rnd.NextDouble()*(max - min) + min, 2);
    }
  }
  return arr;
}

void PrintMatrix(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (j == 0) Console.Write("[");
      if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 6}, ");
      else Console.Write($"{arr[i, j], 6}]");
    }
    Console.WriteLine();
  }
}

double[,] matrix = CreateMatrixRndDouble(numberOfRows, numberOfColumns, minElement, maxElement);
PrintMatrix(matrix);
