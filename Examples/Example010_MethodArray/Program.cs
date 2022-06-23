int[] array = { 1, 34, 5, 5, 6, 845, 245 };

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}
