// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

Console.WriteLine ("Введите первое число: ");
double numberOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());

if (numberTwo > numberOne)
{
    double bufer = numberTwo;
    numberTwo = numberOne;
    numberOne = bufer;
}

double result = numberOne / numberTwo;

if (result == numberTwo)
    Console.WriteLine ($"Число {numberOne} является квадратом числа {numberTwo}");
else
    Console.WriteLine ($"Число {numberOne} не является квадратом числа {numberTwo}");

Console.WriteLine("Другое решение: ");
// Намного более лаконичное решение
if ((numberOne == numberTwo*numberTwo) || (numberTwo == numberOne*numberOne))
    Console.WriteLine ($"Число {numberOne} является квадратом числа {numberTwo}");
else
    Console.WriteLine ($"Число {numberOne} не является квадратом числа {numberTwo}");
