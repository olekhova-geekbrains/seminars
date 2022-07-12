// Задача 50.Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

bool IsExistElement(int[,] arr, int i, int j)
{
 return 0 <= i && i < arr.GetLength(0) && 0 <= j && j < arr.GetLength(1);
}

int[,] matrix = 
{
  {1, 4, 7, 2},
  {5, 9, 2, 3},
  {8, 4, 2, 4}
};

string result = IsExistElement(matrix, row, column) ? $"{matrix[row, column]}" : "такого числа в массиве нет";
Console.WriteLine(result);