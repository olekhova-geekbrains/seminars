// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба 
// индекса чётные, и замените эти 
// элементы на их квадраты. 

Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int maxElement = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
  int[,] array = new int[m, n];
  var rnd = new Random();

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(min, max + 1);
    }
  }
  return array;
}

void PrintMatrix(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (j == 0) Console.Write("[");
      if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ", ");
      else Console.Write(arr[i, j] + "]");
    }
    Console.WriteLine();
  }
}

void ChangeEvenIndex(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
    }
  }
}

int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
ChangeEvenIndex(matrix);
PrintMatrix(matrix);
