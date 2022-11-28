Console.Clear();

int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuandrant(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Это I квадрант");
    if (x < 0 && y > 0) Console.WriteLine("Это II квадрант");
    if (x < 0 && y < 0) Console.WriteLine("Это III квадрант");
    if (x > 0 && y < 0) Console.WriteLine("Это IV квадрант");
    if (x == 0 || y == 0) Console.WriteLine("Неверные данные");
}

int x = DataEntryXY("Введите координаты X: ");
int y = DataEntryXY("Введите координаты Y: ");

FindQuandrant(x, y);