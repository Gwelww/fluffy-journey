// Напишите программу, которая принимает на взод трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number>= 100&& number <= 999) 
{
int lastDiggit = number%10;
Console.WriteLine($"Последняя цифра числа: {lastDiggit}");
}

else Console.WriteLine ("Wrong number");