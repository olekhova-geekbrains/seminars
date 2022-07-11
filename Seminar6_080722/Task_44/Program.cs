// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.WriteLine(arr[i] + "]");
  }
}

int[] CreateFibonacci(int num)
{
  int[] fibon = new int[num];
  for (int i = 0; i < num; i++)
  {
    if (i < 2) fibon[i] = i;
    else fibon[i] = fibon[i - 1] + fibon[i - 2];
  }
  return fibon;
}

int[] fibonacci = CreateFibonacci(number);
PrintArray(fibonacci);