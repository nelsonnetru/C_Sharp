Console.Clear();
int[] array = {11, 12, 23, 34, 45, 45, 56, 67, 98};

int n = array.Length;
int find = 45;
int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break; // прервать после первого найденного
	}
	index++;
}