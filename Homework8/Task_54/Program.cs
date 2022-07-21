// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

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

void SortRow(int[,] arr, int row)
{
    int n = 0;
    while (n < arr.GetLength(1) - 1)
    {
        int maxIndex = n;
        int maxElement = arr[row, n];
        for (int i = n; i < arr.GetLength(1); i++)
        {
            if (arr[row, i] > maxElement)
            {
                maxIndex = i;
                maxElement = arr[row, i];
            }
        }
        int temp = arr[row, n];
        arr[row, n] = arr[row, maxIndex];
        arr[row, maxIndex] = temp;
        n++;
    }
}

void SortMatrixRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }
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

int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrixRow(matrix);
PrintMatrix(matrix);
