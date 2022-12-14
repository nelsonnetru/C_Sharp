// Листинг 4.9 Использование исключений для проверки кода
Console.Clear();

string buf;
double u, i, r;
try
{
    System.Console.Write("Введите напряжение: ");
    u = double.Parse(Console.ReadLine());

    System.Console.Write("Введите сопротивление: ");
    r = double.Parse(Console.ReadLine());

    i = u / r;
    System.Console.WriteLine("Сила тока = " + i);
}
catch (DivideByZeroException)
{
    System.Console.WriteLine("Деление на 0! Сопротивление не может быть равно 0!");
}
catch (FormatException)
{
    System.Console.WriteLine("Неверный формат ввода");
}
catch
{
    Console.WriteLine("Неизвестная ошибка");
}
