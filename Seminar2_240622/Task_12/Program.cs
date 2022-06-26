// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно 

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// вариант 1
// void Multiple(int a, int b)
// {
//   int rem = a % b;
//   if (rem == 0) Console.WriteLine("кратно");
//   else Console.WriteLine($"не кратно, остаток {rem}");
// }

// Multiple(num1, num2);

//вариант 2
int Rem(int a, int b)
{
  int rem = a % b;
  return rem;
}

int remainder = Rem(num1, num2);
string result = remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}";
Console.WriteLine(result);
