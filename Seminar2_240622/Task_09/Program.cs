// Напишите программу, которая выводит случайное число из диапозона [10, 99]
// и выводит наибольшуюю цифру этого числа

int rndNum = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");
// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;

// Console.Write($"Наибольшая цифра числа {rndNum} => ");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(result);

int MaxDigit(int num)
{
  int firstDigit = num / 10;
  int secondDigit = num % 10;
  if (firstDigit == secondDigit) return 0;
  return firstDigit > secondDigit ? firstDigit : secondDigit;
}

// rndNum = 88;

int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");
