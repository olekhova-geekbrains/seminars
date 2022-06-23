// Найти максимум из 9 элементов

int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int a1 = 1;
int b1 = 344;
int c1 = 4811119;
int a2 = 1;
int b2 = 344;
int c2 = 48429;
int a3 = 1;
int b3 = 343;
int c3 = 489;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int max = Max(max1, max2, max3);

int max = Max(
  Max(a1, b1, c1),
  Max(a2, b2, c2),
  Max(a3, b3, c3));

Console.WriteLine(max);