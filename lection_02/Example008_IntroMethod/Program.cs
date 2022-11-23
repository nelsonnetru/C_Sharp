Console.Clear();

int a1 = 12;
int b1 = 15;
int c1 = 22;

int a2 = 12;
int b2 = 155;
int c2 = 22;

int a3 = 12;
int b3 = 15;
int c3 = 22;

int Max (int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result; 
}

int maxResult1 = Max (a1, b1, c1);
int maxResult2 = Max (a2, b2, c2);
int maxResult3 = Max (a3, b3, c3);

int maxResult = Max (maxResult1, maxResult2, maxResult3);
Console.WriteLine($"Максимальное: {maxResult}");

int maxResultAnother = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3));
Console.WriteLine($"Максимальное (метод как аргумент метода): {maxResultAnother}");