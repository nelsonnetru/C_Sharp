// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits (string strDigit) // математически, через деление на 10
{
	int result = 0;
	int digit = Math.Abs(Convert.ToInt32(strDigit)); // избавляемся от отрицательных чисел

	for (; digit > 0;) // равносильно while()
	{
		result += digit % 10;
		digit /= 10;
	}

	return result;
}

double SumDigitsVar2 (string strDigit) // через Char, перебирая всю строку
{
	double result = 0;

	for (int i = strDigit[0] == '-' || strDigit[0] == '+' ? 1 : 0; i < strDigit.Length; i++) // тернарником избавимся от знака, если он есть
	{
		// GetNumericValue возвращает числовое значение типа double для числа, иначе -1
		// для числа с точкой: если символ . перейти на следующую итерацию, иначе в result попадет -1
		if (strDigit[i] == '.') continue;

		result += Char.GetNumericValue(strDigit[i]);
	}

	return result;
}

Console.Clear();
Console.Write("Введите целое число: ");
string number = Console.ReadLine();

int sum1 = SumDigits(number); // только для целых чисел
double sum2 = SumDigitsVar2(number); // с плавающей точкой (включая целые числа)

Console.WriteLine($"Способ 1: Сумма цифр числа {number} = {sum1}");
Console.WriteLine($"Способ 2: Сумма цифр числа {number} = {sum2}");