// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника

Console.Clear();
int rows = 5;

for (int line = 1; line <= rows; line++)
{
    // for (int k = 0; k < rows - line; k++)
    // {
    //     Console.Write(" ");
    // }

    int c = 1;

    for (int i = 1; i <= line; i++)
    {
        Console.Write(" " + c);
        c = c * (line - i) / i;
    }
    Console.WriteLine();
}


