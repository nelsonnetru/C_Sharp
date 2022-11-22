Console.Clear();
Console.Write ("Введите число N: ");

int a = int.Parse(Console.ReadLine());

Console.Write("Четные числа: ");
for (int i=1; i <= a; i++)
{
	if (i%2 == 0)
		Console.Write(i+ " ");
}

Console.WriteLine("");