// Составить 3 массива длинной 10 элементов, которые заполняются случайными числами
// для первого массива от 10 до 20, для воторого от 20 до 30, для третьего от 30 до 40
// Объединить массивы в один по схеме [1,1,1,2,2,2,3,3,3,4,4,4,5,5,5....], полученный 
// массив вывести в строку. Затем отсортировать этот массив ASC, вывести в строку, DESC, 
// вывести в строку
Console.Clear();

void FillArrayRandom (int[] collection, int level) // level - уровень 1, 2, 3...
{
	int length = collection.Length;

	for (int i = 0; i < length; i++)
	{
		collection[i] = new Random().Next(10*level, 10*(level + 1));
	} 
}

void PrintArray (int[] collection) 
{
	for (int i = 0; i  < collection.Length; i++)
	{
		Console.Write(collection[i]+ " ");
	}
}

int[] arrayRandom10 = new int[10];
int[] arrayRandom20 = new int[10];
int[] arrayRandom30 = new int[10];

FillArrayRandom (arrayRandom10, 1);
FillArrayRandom (arrayRandom20, 2);
FillArrayRandom (arrayRandom30, 3);

Console.WriteLine();
PrintArray (arrayRandom10);
Console.WriteLine();
PrintArray (arrayRandom20);
Console.WriteLine();
PrintArray (arrayRandom30);

Console.WriteLine();
Console.WriteLine();

int[] arrayMerged = new int[arrayRandom10.Length + arrayRandom20.Length + arrayRandom30.Length];
arrayRandom10.CopyTo(arrayMerged, 0);
arrayRandom20.CopyTo(arrayMerged, arrayRandom10.Length);
arrayRandom30.CopyTo(arrayMerged, arrayRandom10.Length + arrayRandom20.Length);

PrintArray (arrayMerged);
Console.WriteLine();
Array.Sort(arrayMerged);
PrintArray(arrayMerged);
Console.WriteLine();
