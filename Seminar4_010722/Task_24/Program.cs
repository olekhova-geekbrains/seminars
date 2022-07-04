// Task_24
//На вход число А, на выход сумма чисел от 1 до А

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum += i;
//     if (i < number) Console.Write($"{i} + ");
//     else Console.Write($"{i} = ");
// }
// Console.WriteLine(sum);

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int summer = Sum(number);
Console.WriteLine($"Сумма чисел от 1 до {number}: {summer}");
