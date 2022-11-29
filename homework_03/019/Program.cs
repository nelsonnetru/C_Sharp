// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReverseNumber (int tmpNumber) // метод "разворота" числа
{
	int div = 0; // в этой переменной будет храниться развернутое число
	int rem; // остаток от деления на 10 в цикле

	while (tmpNumber > 0)
	{
		rem = tmpNumber % 10;
		div = div * 10 + rem;
		tmpNumber = tmpNumber / 10;
	}
	return div;
}

Console.Clear();
Console.Write("Введите положительное пятизначное число: "); // палиндромами могут быть только положительные числа
int number = int.Parse(Console.ReadLine());

if (number >= 10000 && number <= 99999) // проверка пятизначного числа
{
	int revNumber = ReverseNumber(number); // "разворот" числа в методе ReverseNumber

	if (number == revNumber)
		Console.WriteLine ($"Число {number} является палиндромом");
	else 
		Console.WriteLine ($"Число {number} не является палиндромом");
}
else 
	Console.WriteLine ("Вводимое число должно быть положительным и пятизначным!");