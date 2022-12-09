// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void MakeBinaryView (int number)
{
	if (number == 0) return;
	else
		MakeBinaryView(number/2);
		Console.Write(number%2);
}

string MakeBinaryViewStr (int number, string outputStr)
{
	if (number == 0) return String.Empty;
	else
	{
		outputStr = Convert.ToString(number%2);
		outputStr = MakeBinaryViewStr(number/2, outputStr) + outputStr;
	}

	return outputStr;
}

// MakeBinaryView(number);

Console.Clear();
Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());

string binaryView = String.Empty;
binaryView = MakeBinaryViewStr(number, binaryView);

Console.WriteLine(binaryView);
Console.WriteLine("Проверка: " + Convert.ToString(number, 2));