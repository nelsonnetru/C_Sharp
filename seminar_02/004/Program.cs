// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ostatok7 = number % 7; // остаток от деления на 7
int ostatok23 = number % 23; // остаток от деления на 23

if (ostatok7 == 0 && ostatok23 == 0)
    Console.WriteLine("Число одновременно кратно и 7, и 23");
else
    Console.WriteLine("Число не кратно и 7, и 23 одновременно");