// Task_26 на вход число, на выход количество цифр в этом числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Count(int num)
{
    int localNum = num;
    int count = 0;
    while (localNum != 0)
    {
        localNum /= 10;
        count += 1;
    }
    return count;
}
int count = Count(number);
Console.WriteLine(count);
