Console.Clear();
Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());

double square = Math.Pow(b, 2);

if (a == square)
    Console.WriteLine($"Число {a} является квадратом числа {b}");
else 
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
