// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

long MyPOW (int tmpA, int tmpB)
{
	long result = 1; // принимаем соглашение, что 0^0 = 1
	for (int i = 1; i <= tmpB; i++) // для степени ноль (tmpB = 0) цикл не начнется и result будет = 1 (даже для tmpA = 0)
	{
		result *= tmpA;
	}
	return result;
}

int NumberEntry (string str)
{
	Console.Write(str);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

Console.Clear();
int a = NumberEntry("Введие число А: ");
int b = NumberEntry("Введие число B: ");

long pow = MyPOW (a, b);
Console.WriteLine("А в степени B: " + pow);