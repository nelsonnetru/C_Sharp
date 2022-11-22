Console.Clear();
Console.Write ("Введите число: ");

int a = int.Parse(Console.ReadLine());

if (a%2 == 0)
	Console.WriteLine("Да, число " +a+ " четное");
else 
	Console.WriteLine("Нет, число " +a+ " нечетное");