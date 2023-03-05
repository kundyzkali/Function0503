// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitNumbers = DigitNumbers(number);
Console.WriteLine($"Количество цифр в числе {digitNumbers}");

int DigitNumbers(int num)
{
    int digits = 0;
    while (num>0)
    {
      num = num / 10;  
      digits++; 
    }
    return digits;
}