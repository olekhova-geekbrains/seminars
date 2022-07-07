string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
  for (int columns = 0; columns < 5; columns++)
  {
    Console.Write($"-{table[rows, columns]}-");
  }
  Console.WriteLine();
}

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void PrintImage(int[,] image)
{
  for (int i = 0; i < image.GetLength(0); i++)
  {
    for (int j = 0; j < image.GetLength(1); j++)
    {
      if (image[i, j] == 0) Console.Write($" ");
      else Console.Write("+");
    }
    Console.WriteLine();
  }
}

int[,] img = new int[,]{
  {1, 1, 1, 1, 1, 1, 1},
  {1, 0, 0, 0, 0, 0, 1},
  {1, 1, 1, 1, 1, 1, 1}
};

void FillImage(int row, int col)
{
  if (img[row, col] == 0)
  {
    img[row, col] = 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
  }
}

PrintImage(img);
Console.WriteLine();
FillImage(1, 1);
PrintImage(img);
