Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( (number >= 1) && (number<=7))
{
	string[] days = new string[8];

	days[1] = "Понедельник";
	days[2] = "Вторник";
	days[3] = "Среда";
	days[4] = "Четверг";
	days[5] = "Пятница";
	days[6] = "Суббота";
	days[7] = "Воскресенье";

	Console.WriteLine($"День {number}: {days[number]}");
}
else 
	Console.WriteLine("Необходимо ввести номер дня от 1 до 7!");