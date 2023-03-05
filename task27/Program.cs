Задача 27: Напишите программу, которая 
1.принимает на вход число и 
2.выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);
Console.WriteLine($"Cумма цифр в числе : {number} = {SumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    while (number > 0)
 {
    sum += number % 10;
    number = number / 10;
    }
    return sum;
}