﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите квадрат: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 == number2*number2)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }