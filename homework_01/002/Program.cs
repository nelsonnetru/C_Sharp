Console.Clear();
Console.Write ("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write ("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
	Console.WriteLine ("max = " +a);
}
else if (a==b) 
{
	Console.WriteLine ("a == b");
}
else 
{
	Console.WriteLine ("max = " +b);
}