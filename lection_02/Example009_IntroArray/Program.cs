Console.Clear();

int[] array = {11, 12, 13, 14, 15, 16, 7, 81, 19};

int Max (int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result; 
}

int maxResult1 = Max (array[0], array[1], array[2]);
int maxResult2 = Max (array[3], array[4], array[5]);
int maxResult3 = Max (array[6], array[7], array[8]);

int maxResult = Max (maxResult1, maxResult2, maxResult3);
Console.WriteLine($"Максимальное: {maxResult}");

int maxResultAnother = Max (Max (array[0], array[1], array[2]), Max (array[3], array[4], array[5]), Max (array[6], array[7], array[8]));
Console.WriteLine($"Максимальное (метод как аргумент метода): {maxResultAnother}");