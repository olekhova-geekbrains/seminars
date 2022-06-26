﻿// 11.Напишите программу,
//  которая выводит случайное трёхзначное число и 
//  удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98 

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {rndNum}");

int RmSecDigit(int num)
{
  int firstDigit = num / 100;
  int thirdDigit = num % 10;
  int result = firstDigit * 10 + thirdDigit;
  return result;
}

int res = RmSecDigit(rndNum);
Console.WriteLine($"Удалили вторую цифру => {res}");
