// Задача 33: Задайте массив.Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. 
// массив[6, 7, 19, 345, 3]->нет
// массив[6, 7, 19, 345, 3]->да 

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] array = { 6, 7, 19, 345, 3 };

string CheckNumber(int[] arr, int num)
{
  string res = "нет"; 
  for (int i = 0; i < arr.Length; i++) 
  { 
    if (arr[i] == num) res = "да"; 
  }
  return res;
}
string result = CheckNumber(array, number); 
Console.WriteLine(result);