// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int num4 = Convert.ToInt32(Console.ReadLine());
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

int[,] ProductMatrices(int[,] arr1, int[,] arr2)
{
    int m = arr1.GetLength(0);
    int k = arr1.GetLength(1);
    int n = arr2.GetLength(1);
    int[,] prod = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int l = 0; l < k; l++)
            {
                sum += arr1[i, l] * arr2[l, j];
            }
            prod[i, j] = sum;
        }
    }
    return prod;
}

if (num2 == num3)
{
    int[,] matrix1 = CreateMatrixRndInt(num1, num2, minElement, maxElement);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = CreateMatrixRndInt(num3, num4, minElement, maxElement);
    PrintMatrix(matrix2);
    Console.WriteLine();
    int[,] product = ProductMatrices(matrix1, matrix2);
    PrintMatrix(product);
}
else
{
    Console.WriteLine("Невозможно посчитать произведение матриц. Количество столбцов в первой матрице должно совпадать с количеством строк во второй.");
}
