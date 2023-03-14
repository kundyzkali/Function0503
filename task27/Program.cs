Задача 27: Напишите программу, которая 
1.принимает на вход число и 
2.выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{GetSumAllDigits(number)}");

int GetSumAllDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}