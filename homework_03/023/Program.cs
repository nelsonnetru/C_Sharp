// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void TableCubes(string str)
{
    Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    int count = 1;
    double cube;

    Console.WriteLine($"Таблица кубов чисел от {count} до {number}:");
    while (count <= number)
    {
        cube = Math.Pow(count, 3);
        Console.Write(cube + " ");
        count++;
    }
    Console.WriteLine();
}

TableCubes("Введите число N: ");