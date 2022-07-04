//Task_28 На вход число N, на выход произведение от 1 до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
  int proud = 1;
  for (int i = 1; i <= num; i++)
  {
    checked
    {
      proud *= i;
    }
  }
  return proud;
}

int factorial = Factorial(number);
Console.WriteLine(factorial);
