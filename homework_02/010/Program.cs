﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int digit = Convert.ToInt16(Console.ReadLine());

int secondDigit = (digit / 10) % 10;
Console.WriteLine("Вторая цифра числа: " + secondDigit);
