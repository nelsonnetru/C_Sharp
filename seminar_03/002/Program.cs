// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Clear();

int DataEntryCH(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindXY (int ch)
{
    if (ch == 1) Console.WriteLine("Координаты X > 0, Y > 0");
    if (ch == 2) Console.WriteLine("Координаты X < 0, Y > 0");
    if (ch == 3) Console.WriteLine("Координаты X < 0, Y < 0");
    if (ch == 4) Console.WriteLine("Координаты X > 0, Y < 0");
}

int quadrant = DataEntryCH("Введите четверть: ");

FindXY(quadrant);