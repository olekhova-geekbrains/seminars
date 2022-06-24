// 11.Напишите программу,
//  которая выводит случайное трёхзначное число и 
//  удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98 

int rndNum = new Random().Next(10, 100);
int rmSecDigit(int num)
{
  int firstGigit = num / 100;
  int thirdDigit = num % 10;
}