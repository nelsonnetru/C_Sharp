Console.Clear();
Console.Write ("Введите число N: ");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Четные числа: ");
for (int i=1; i <= N; i++)
{
	if (i%2 == 0)
		Console.Write(i+ " ");
}
Console.WriteLine("");

// Второй вариант (меньше итераций цикла)
for (int i=2; i <= N; i=i+2)
{
	Console.Write(i+ " ");
}
Console.WriteLine("");
