// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondtDigit = Convert.ToInt32(Console.ReadLine());

int ostatok = firstDigit % secondtDigit;

if (ostatok == 0)
    Console.WriteLine("Первое число кратно второму");
else
    Console.WriteLine("Остаток от деления " +ostatok);