// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 29
// Функция Аккермана определяется рекурсивно 
// для неотрицательных целых чисел m и n следующим образом:
//                               n + 1 ,  m = 0; 
// A(m, n) =  {            A(m − 1, 1) ,  m > 0 , n = 0; 
//               A(m − 1, A(m, n − 1)) ,  m > 0 , n > 0.

Console.Clear();
Console.WriteLine("Введите неотрицательное число M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0) Console.WriteLine("Введены некорректные значения");
else
{
  int ack = Ackermann(numM, numN);
  Console.WriteLine($"Функция Аккермана для этих чисел равна {ack}");
}

int Ackermann(int a, int b)
{
  if (a == 0) return b + 1;
  if (b == 0) return Ackermann(a - 1, 1);
  else return Ackermann(a - 1, Ackermann(a, b - 1));
}
