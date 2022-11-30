Console.Clear();
int[] array = {2,4,5,6,7,8,9,1,1,0};

void ArraySortASC (int[] arr) // сортировка по возрастанию
{
	for (int i = 0; i < arr.Length - 1; i++)
	{
		int minimal = arr[i];
		for (int j = i + 1; j < arr.Length; j++ )
		{
			if (arr[j] < minimal)
			{
				int temporary = arr[i];
				arr[i] = arr[j];
				arr[j] = temporary;
			}
		}
	}
}

void PrintArray (int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write(arr[i] + " ");
	}
}

PrintArray(array);
Console.WriteLine();
ArraySortASC(array);
PrintArray(array);
Console.WriteLine();