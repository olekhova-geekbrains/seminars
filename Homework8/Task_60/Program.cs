// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите три размерности массива.");
Console.WriteLine("Первая размерность: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая размерность: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третья размерность: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[,,] CreateArray3D(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    int count = 10;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = count++;
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int l = arr.GetLength(2);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = CreateArray3D(num1, num2, num3);
PrintArray3D(matrix);
