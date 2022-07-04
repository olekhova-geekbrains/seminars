//Task_30 вывести массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] array = new int[8];
int index = 0;
var rnd = new Random();
while (index < array.Length)
{
  array[index] = rnd.Next(0, 2);
  index++;
}
for (int i = 0; i < array.Length; i++)
{
  if (i == 0) Console.Write("[");
  if (i < array.Length - 1) Console.Write(array[i] + ",");
  else Console.WriteLine(array[i] + "]");
}

// int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
