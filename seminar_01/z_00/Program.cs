Console.Clear();
Console.Write("Введите число ");

double a = Convert.ToDouble(Console.ReadLine());
double square = a*a;
double square_2 = Math.Pow(a, 2);

Console.WriteLine("Квадрат числа " + a +" равен " +(a*a));
Console.WriteLine($"Квадрат числа {a} равен {square}");
Console.WriteLine($"Квадрат числа {a} равен {square_2}");
