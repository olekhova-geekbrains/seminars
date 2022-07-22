// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int s)
{
    int[,] array = new int[s, s];
    int count = 1;
    for (int i = 0; i <= s / 2; i++)
    {
        for (int j = i; j < s - i; j++)
        {
            array[i, j] = count++;
        }
        for (int k = i + 1; k < s - i; k++)
        {
            array[k, s - i - 1] = count++;
        }
        for (int l = s - i - 2; l >= i; l--)
        {
            array[s - i - 1, l] = count++;
        }
        for (int m = s - i - 2; m >= i + 1; m--)
        {
            array[m, i] = count++;
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
            if (j < arr.GetLength(1) - 1) 
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrix(size);
PrintMatrix(matrix);